using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BookDistSystem
{
    public delegate void priceCutEvent();
    public class Publisher
    {
        public static int numPriceCuts = 0;
        static OrderProcessing Processor = new OrderProcessing();
        public static event priceCutEvent priceCut;

        public Publisher()
        {

        }

        /// <summary>
        /// method to be called by main as a thread
        /// </summary>
        public void RunPublisher()
        {
            while (true)
            {
                lock (MultiCellBuffer.pubLock1)
                {
                    if (numPriceCuts >= 20)
                    {
                        numPriceCuts = 0;
                        MultiCellBuffer.PublisherRunning = false;
                        (Application.OpenForms[0] as MainForm).setSendStatustxt("Idle", 1);
                        //wait for a bookstore to die and set back true then terminate
                        while (!MultiCellBuffer.PublisherRunning) ;
                        //this will terminate a publisher
                        break;
                    }
                }
                //split this work up to further utilize multithreading
                lock (MultiCellBuffer.pubLock2)
                {
                    if (MultiCellBuffer.OrderRecieved)
                    {
                        MultiCellBuffer.Order.setSenderId(Thread.CurrentThread.ManagedThreadId);
                        (Application.OpenForms[0] as MainForm).setSendIDtxt(Thread.CurrentThread.ManagedThreadId, 1);
                        //simulate work being done
                        Thread.Sleep(10000);
                        //MessageBox.Show("Thread number: " + Thread.CurrentThread.ManagedThreadId.ToString() + 
                        //    " is processing the order amount of: " + MultiCellBuffer.Order.getAmount().ToString());
                        //MultiCellBuffer.Order.setUnitPrice(PricingModel());
                        double calculatedPrice = PricingModel(MultiCellBuffer.Order.getAmount());
                        MultiCellBuffer.PriceCalculated = true;
                        MultiCellBuffer.OrderRecieved = false;
                        if (MultiCellBuffer.bookStoreThreadCnt < 5)
                        {
                            Thread bookStoreThread = new Thread(() => BookStore.RunStore(calculatedPrice));
                            bookStoreThread.Start();
                        }
                        else
                        {
                            MessageBox.Show("All bookstores busy");
                        }
                    }
                }

                lock (MultiCellBuffer.pubLock3)
                {
                    if (MultiCellBuffer.NewMsg)
                    {
                        for(int i = 0; i < 3; i++)
                        {
                            if (MultiCellBuffer.buffer[i] != null)
                            {
                                string[] orderInfo = Decoder.Decode(MultiCellBuffer.buffer[i]);
                                //free the space in the buffer
                                MultiCellBuffer.buffer[i] = null;
                                MultiCellBuffer.cells.Release();
                                //start oder processing thread
                                Thread ProcessOrder = new Thread(() => Processor.Process(orderInfo));
                                ProcessOrder.Start();
                                break;
                            }
                        }
                        MultiCellBuffer.NewMsg = false;
                    }
                }
            }
        }

        public double PricingModel(int orderAmount)
        {
            Random rnd = new Random();
            double price = (rnd.NextDouble() * 150) + 50;

            if(orderAmount > 10 && orderAmount <= 20)
            {
                //price cut
                priceCut?.Invoke();
                price = price - 5;
                numPriceCuts++;
            }
            else if(orderAmount > 20 && orderAmount <= 30)
            {
                //price cut
                priceCut?.Invoke();
                price = price - 10;
                numPriceCuts++;
            }
            else if(orderAmount > 30)
            {
                //price cut
                priceCut?.Invoke();
                price = price - 15;
                numPriceCuts++;
            }
            else
            {
                //no price cut, do nothing, less than 10 orders
            }

            return price;
        }
    }
}
