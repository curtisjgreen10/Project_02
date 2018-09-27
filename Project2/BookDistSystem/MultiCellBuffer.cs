using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BookDistSystem
{
    /// <summary>
    /// This class holds all shared data between threads
    /// </summary>
    public class MultiCellBuffer
    {
        static public string[] buffer = { null, null, null};
        static public Semaphore cells;
        
        private int size;
        static public object pubLock1 = new object();
        static public object pubLock2 = new object();
        static public object pubLock3 = new object();
        static public object pubLock4 = new object();
        static public object bookLock1 = new object();
        static public object bookLock2 = new object();
        static public object bookLock3 = new object();
        static public OrderClass Order = new OrderClass();
        
        public MultiCellBuffer(int arrSize)
        {
            size = arrSize;
            cells = new Semaphore(3, 3); 
        }
        static public bool PriceCalculated { get; set; } = false;
        static public bool OrderRecieved { get; set; } = false;
        static public bool PublisherRunning { get; set; } = true;
        static public bool MessageSent { get; set; } = false;
        static public string EncodedMsg { get; set; }
        static public bool NewMsg { get; set; } = false;
        static public int bookStoreThreadCnt { get; set; } = 0;
        static public int publisherThreadCnt { get; set; } = 0;
        static public int numPriceCuts { get; set; } = 0;

        /// <summary>
        /// thread that runs forever to insert encoded string into buffer
        /// </summary>
        public void RunBuffer()
        {
            while (true)
            {
                if (MessageSent)
                {
                    cells.WaitOne();
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
