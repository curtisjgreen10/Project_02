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
        public void RunStore()
        {
            while (true)
            {
                lock (MultiCellBuffer.bookLock)
                {
                    if (MultiCellBuffer.PriceCalculated)
                    {
                        MultiCellBuffer.Order.setReceieverId(Thread.CurrentThread.ManagedThreadId);
                        MultiCellBuffer.EncodedMsg = EncodeOrder(MultiCellBuffer.Order.getUnitPrice());
                        MessageBox.Show("Thread number: " + Thread.CurrentThread.ManagedThreadId.ToString() +
                        " encoded calculated price: " + MultiCellBuffer.Order.getUnitPrice().ToString() + " into\n " + 
                        MultiCellBuffer.EncodedMsg);
                        MultiCellBuffer.PriceCalculated = false;
                        MultiCellBuffer.MessageSent = true;
                    }
                }

                lock (MultiCellBuffer.validLock)
                {
                    if (MultiCellBuffer.OrderValid)
                    {
                        //should probably make sure that the same thread executes this that performed the above code
                        MessageBox.Show("Valid order processed by thread number: " + 
                            Thread.CurrentThread.ManagedThreadId.ToString());
                        MultiCellBuffer.OrderValid = false;
                    }
                }
            }
        }

        public String EncodeOrder(double unitPrice)
        {
            MultiCellBuffer.Order.setUnitPrice(unitPrice);
            return Encoder.encode(MultiCellBuffer.Order);
        }
    }
}
