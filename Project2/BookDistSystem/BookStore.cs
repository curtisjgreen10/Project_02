using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BookDistSystem
{
    /// <summary>
    /// Bookstore class
    /// </summary>
    public class BookStore
    { 
        /// <summary>
        /// Constuctor
        /// </summary>
        public BookStore()
        {

        }

        /// <summary>
        /// Thread method to call from main 
        /// </summary>
        public static void RunStore(double calculatedrice)
        {
            int threadNum;
            lock (MultiCellBuffer.bookLock1)
            {
                //increment shared thread count variable and store into local thread variable to determine thread number 
                MultiCellBuffer.bookStoreThreadCnt++;
                threadNum = MultiCellBuffer.bookStoreThreadCnt;
                (Application.OpenForms[0] as MainForm).setRcvrIDtxt(Thread.CurrentThread.ManagedThreadId, threadNum - 1);
                (Application.OpenForms[0] as MainForm).setRcvrStatustxt("Running", threadNum - 1);
            }
            //simulate work
            Thread.Sleep(1000);
            while (true)
            {
                lock (MultiCellBuffer.bookLock2)
                {
                    if (!MultiCellBuffer.PublisherRunning)
                    {
                        MultiCellBuffer.PublisherRunning = true;
                        MultiCellBuffer.bookStoreThreadCnt--;
                        (Application.OpenForms[0] as MainForm).setRcvrIDtxt(-1, threadNum - 1);
                        (Application.OpenForms[0] as MainForm).setRcvrStatustxt("Idle", threadNum - 1);
                        //terminate
                        break;
                    }
                }

                //maybe make this an event
                lock (MultiCellBuffer.bookLock3)
                {
                    if (MultiCellBuffer.PriceCalculated)
                    {
                        (Application.OpenForms[0] as MainForm).encodeOrder("Encoding", threadNum - 1);
                        //simulate work
                        Thread.Sleep(1000);
                        MultiCellBuffer.Order.setReceieverId(Thread.CurrentThread.ManagedThreadId);
                        //encode order
                        MultiCellBuffer.EncodedMsg = EncodeOrder(calculatedrice);
                        MultiCellBuffer.MessageSent = true;
                        //reset the PriceCalculated bool so bookstore can continuously check for order to encode
                        MultiCellBuffer.PriceCalculated = false;
                        (Application.OpenForms[0] as MainForm).encodeOrder(" ", threadNum - 1);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for price cut raised in publisher
        /// </summary>
        static public void Publisher_priceCut()
        {
            //increment price cuts
            MultiCellBuffer.numPriceCuts++;
            //update GUI
            (Application.OpenForms[0] as MainForm).setPriceCuts(MultiCellBuffer.numPriceCuts);
        }

        /// <summary>
        /// Event handler for order processed rasied in OrderProcessing class
        /// </summary>
        static public void Process_orderProcessed()
        {
            //addadd some code here maybe
            //MessageBox.Show("VALID ORDER PROCESSED!!");
        }

        /// <summary>
        /// Creates an encoded order string using #'s
        /// </summary>
        /// <param name="unitPrice">the calculated price of a single book</param>
        /// <returns>string</returns>
        public static string EncodeOrder(double unitPrice)
        {
            MultiCellBuffer.Order.setUnitPrice(unitPrice);
            return Encoder.encode(MultiCellBuffer.Order);
        }
    }
}
