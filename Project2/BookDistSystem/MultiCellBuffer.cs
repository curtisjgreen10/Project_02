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
        static int orderAmount = 0;

        public MultiCellBuffer(int size)
        {
            buffer = new Array[size];
        }

        static public int OrderAmount
        {
            get
            {
                return orderAmount;
            }
            set
            {
                orderAmount = value;
            }
        }
    }
}
