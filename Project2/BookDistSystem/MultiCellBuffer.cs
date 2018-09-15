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
        static public string[] buffer = { null, null, null};
        private int size;
        static public object priceLock = new object();
        static public object orderLock = new object();
        static public object bookLock = new object();
        static public object validLock = new object();
        static public OrderClass Order = new OrderClass();
        
        public MultiCellBuffer(int arrSize)
        {
            size = arrSize;
        }

        static public bool OrderRecieved { get; set; } = false;
        static public bool PriceCalculated { get; set; } = false;
        //static public double UnitPrice { get; set; } = 0;
        static public bool NewSender { get; set; } = false;
        static public bool MessageSent { get; set; } = false;
        static public string EncodedMsg { get; set; }
        static public bool NewMsg { get; set; } = false;
        static public bool OrderValid { get; set; } = false;

        public void RunBuffer()
        {
            while (true)
            {
                if (MessageSent)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        if(buffer[i] == null)
                        {
                            buffer[i] = EncodedMsg;
                            NewMsg = true;
                            break;
                        }
                    }
                    MessageSent = false;
                }
            }
        }
    }
}
