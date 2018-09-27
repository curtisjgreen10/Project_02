using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BookDistSystem
{
    /// <summary>
    /// delegate for price cut event
    /// </summary>
    public delegate void priceCutEvent();

    /// <summary>
    /// Publisher class
    /// </summary>
    public class Publisher
    {
        static OrderProcessing Processor = new OrderProcessing();
        public static event priceCutEvent priceCut;

        /// <summary>
        /// constructor
        /// </summary>
        public Publisher()
        {

        }

        /// <summary>
        /// method to be called by main as a thread
        /// </summary>
        public static void RunPublisher()
        {
            int threadNum;
            lock (MultiCellBuffer.pubLock4)
            {
                MultiCellBuffer.publisherThreadCnt++;
                threadNum = MultiCellBuffer.publisherThreadCnt;
            }

            while (true)
            {
                lock (MultiCellBuffer.pubLock1)
                {
                    //publisher termination condition
                    if (MultiCellBuffer.numPriceCuts >= 20)
                    {
                        //reset numPriceCuts
                        MultiCellBuffer.numPriceCuts = 0;
                        //let the bookstore know that a publisher has died
                        MultiCellBuffer.PublisherRunning = false;
                        //update GUI
                        (Application.OpenForms[0] as MainForm).setSendIDtxt(-1, threadNum - 1);
                        (Application.OpenForms[0] as MainForm).setSendStatustxt("Idle", threadNum - 1);
                        //wait for a bookstore to die and set back true then terminate
                        while (!MultiCellBuffer.PublisherRunning) ;
                        //update thread count
                        MultiCellBuffer.publisherThreadCnt--;
                        //this will terminate a publisher
                        break;
                    }
                }
                
                lock (MultiCellBuffer.pubLock2)
                {
                    // true if order received from the GUI (button press)
                    if (MultiCellBuffer.OrderRecieved)
                    {
                        //update shared order object with senderID (thread ID)
                        MultiCellBuffer.Order.setSenderId(Thread.CurrentThread.ManagedThreadId);
                        //update GUI with sender ID (thread ID)
                        (Application.OpenForms[0] as MainForm).setSendIDtxt(Thread.CurrentThread.ManagedThreadId, threadNum - 1);
                        (Application.OpenForms[0] as MainForm).setSendStatustxt("Running", threadNum - 1);
                        //simulate work being done
                        Thread.Sleep(1000);
                        //calculate price using the pricing model and book amount received through GUI
                        double calculatedPrice = PricingModel(MultiCellBuffer.Order.getAmount());
                        //if there are less than 5 bookstores start another
                        if (MultiCellBuffer.bookStoreThreadCnt < 5)
                        {
                            Thread bookStoreThread = new Thread(() => BookStore.RunStore(calculatedPrice));
                            bookStoreThread.IsBackground = true;
                            bookStoreThread.Start();
                        }
                        //let the bookstore know the price has been calculated and to do some work
                        MultiCellBuffer.PriceCalculated = true;
                        //reset OrderRecieved bool back to false so more orders can be received from GUI
                        MultiCellBuffer.OrderRecieved = false;
                    }
                }

                lock (MultiCellBuffer.pubLock3)
                {
                    //true if bookstore has placed a new encoded message in the buffer
                    if (MultiCellBuffer.NewMsg)
                    {
                        //find which cell has the message (non-null cell)
                        for(int i = 0; i < 3; i++)
                        {
                            if (MultiCellBuffer.buffer[i] != null)
                            {
                                //call decode
                                string[] orderInfo = Decoder.Decode(MultiCellBuffer.buffer[i]);
                                //free the space in the buffer
                                MultiCellBuffer.buffer[i] = null;
                                //free a semaphore resource
                                MultiCellBuffer.cells.Release();
                                //start oder processing thread
                                
                                Thread ProcessOrder = new Thread(() => Processor.Process(orderInfo, threadNum));
                                ProcessOrder.IsBackground = true;
                                ProcessOrder.Start();
                                break;
                            }
                        }
                        //reset NewMsg bool to decode and process more messages in buffer
                        MultiCellBuffer.NewMsg = false;
                    }
                }
            }
        }

        /// <summary>
        /// Calculates the book price based number of books to order
        /// </summary>
        /// <param name="orderAmount">number of books to orders</param>
        /// <returns>double</returns>
        public static double PricingModel(int orderAmount)
        {
            //limits
            int MAX = 200;
            int MIN = 50;
            Random rnd = new Random();
            double price = (rnd.NextDouble() * MAX - MIN) + MIN;

            if(orderAmount > 10 && orderAmount <= 20)
            {
                price = price - 5;
                //price cut, raise event if there are subscribers
                priceCut?.Invoke();
            }
            else if(orderAmount > 20 && orderAmount <= 30)
            {
                price = price - 10;
                //price cut, raise event if there are subscribers
                priceCut?.Invoke();
            }
            else if(orderAmount > 30)
            {
                price = price - 15;
                //price cut, raise event if there are subscribers
                priceCut?.Invoke();
            }
            return price;
        }
    }
}
