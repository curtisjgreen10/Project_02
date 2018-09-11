using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class BookStore
    { 
        public static string priceCutEventHandler(OrderClass obj)
        {
            string encoded = Encoder.encode(obj);
            return encoded; // Send to MultiCellBuffer, call or return?
        }
    }
}
