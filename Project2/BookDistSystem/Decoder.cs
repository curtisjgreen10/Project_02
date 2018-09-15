using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class Decoder
    {
        public Decoder()
        {

        }

        public static string[] Decode(string encodedStr)
        {
            string[] decodedStrings = encodedStr.Split('#');
            return decodedStrings;
        }
    }
}
