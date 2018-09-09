using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemClient
{
    class BookStore
    {
        public BookStore(){

        }

        public OrderClass myOrder(OrderClass obj){
            Encoder.send(obj);  //Send to encoder
            //send something to publisher
        }

    }
}
