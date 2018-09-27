using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class Decoder
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Decoder()
        {

        }

        /// <summary>
        /// Basic decode method
        /// </summary>
        /// <param name="encodedStr"></param>
        /// <returns></returns>
        public static string[] Decode(string encodedStr)
        {
            string[] decodedStrings = encodedStr.Split('#');
            return decodedStrings;
        }
    }
}
