using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BookDistSystem
{

    public class MultiCellBuffer
    {
        Array buffer;
        static public object pubLock = new object();
        static public object bookLock = new object();
        static public OrderClass Order = new OrderClass();
        public MultiCellBuffer(int size)
        {
            buffer = new Array[size];
        }

        //static public int OrderAmount { get; set; } = 0;
        static public bool OrderRecieved { get; set; } = false;
        static public bool PriceCalculated { get; set; } = false;
        static public double UnitPrice { get; set; } = 0;
        static public bool NewSender { get; set; } = false;
    }
}
