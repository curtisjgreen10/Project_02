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
                        string temp = EncodeOrder(MultiCellBuffer.UnitPrice);
                        MessageBox.Show("Thread number: " + Thread.CurrentThread.ManagedThreadId.ToString() +
                        " encoded calculated price: " + MultiCellBuffer.UnitPrice.ToString() + " into\n " + temp);

                        MultiCellBuffer.PriceCalculated = false;
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
