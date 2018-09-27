using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class Encoder
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Encoder()
        {

        }

        /// <summary>
        /// basic encode method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>string</returns>
        public static string encode(OrderClass obj)
        {
            string s = obj.getSenderId().ToString() + "#";  // (1) SenderId
            string c = obj.getCardNo().ToString() + "#";    // (2) Card Num
            string r = obj.getReceiverId().ToString() + "#";// (3) ReceieverID
            string a = obj.getAmount().ToString() + "#";    // (4) Amount
            string u = obj.getUnitPrice().ToString() +"#";  // (5) Unit Price

            string encoded = s + c + r + a + u;
            return encoded;
        }
    }
}
