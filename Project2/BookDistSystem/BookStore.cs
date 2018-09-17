using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BookDistSystem
{
    public class BookStore
    { 
        public BookStore()
        {

        }

        public static string priceCutEventHandler(OrderClass obj)
        {
            string encoded = Encoder.encode(obj);
            return encoded; // Send to MultiCellBuffer, call or return?
        }

        /// <summary>
        /// Thread method to call from main 
        /// </summary>
        public static void RunStore(double calculatedrice)
        {
            int num = MultiCellBuffer.bookStoreThreadCnt++;
            (Application.OpenForms[0] as MainForm).setRcvrIDtxt(Thread.CurrentThread.ManagedThreadId, num);
            (Application.OpenForms[0] as MainForm).setRcvrStatustxt("Running", num);
            //simulate work
            Thread.Sleep(10000);
            while (true)
            {
                
                lock (MultiCellBuffer.bookLock)
                {
                    if (!MultiCellBuffer.PublisherRunning)
                    {
                        MultiCellBuffer.PublisherRunning = true;
                        MultiCellBuffer.bookStoreThreadCnt--;
                        (Application.OpenForms[0] as MainForm).setRcvrStatustxt("Idle", num);
                        //terminate
                        break;
                    }
                }

                if (MultiCellBuffer.PriceCalculated)
                {
                    MultiCellBuffer.Order.setReceieverId(Thread.CurrentThread.ManagedThreadId);
                    MultiCellBuffer.EncodedMsg = EncodeOrder(calculatedrice);
                    //MessageBox.Show("Bookstore thread number: " + Thread.CurrentThread.ManagedThreadId.ToString() +
                    //" encoded calculated price: " + calculatedrice.ToString() + " into\n " + MultiCellBuffer.EncodedMsg);
                    MultiCellBuffer.MessageSent = true;
                    MultiCellBuffer.PriceCalculated = false;
                }

                //wait here for order to be processed
                while (!MultiCellBuffer.OrderProcessed) ;
                if (MultiCellBuffer.OrderValid)
                {
                    //should probably make sure that the same thread executes this that performed the above code
                    //MessageBox.Show("Valid order processed by bookstore thread number: " +
                    //    Thread.CurrentThread.ManagedThreadId.ToString());
                    MultiCellBuffer.OrderValid = false;
                }
                MultiCellBuffer.OrderProcessed = false;
            }
        }

        static public void Publisher_priceCut()
        {
            //add some math operations in here
            MessageBox.Show("PRICE CUT!!");
        }

        public static string EncodeOrder(double unitPrice)
        {
            MultiCellBuffer.Order.setUnitPrice(unitPrice);
            return Encoder.encode(MultiCellBuffer.Order);
        }
    }
}
