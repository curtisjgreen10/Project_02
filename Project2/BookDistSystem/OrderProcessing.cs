using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class OrderProcessing
    {
        public OrderProcessing()
        {

        }

        public void Process(string[] orderInfo)
        {
            //assume valid until otherwise proven
            MultiCellBuffer.OrderValid = true;
            int senderID = Convert.ToInt32(orderInfo[0]);
            int cardNo = Convert.ToInt32(orderInfo[1]);
            int recvrID = Convert.ToInt32(orderInfo[2]);
            int amount = Convert.ToInt32(orderInfo[3]);
            double unitPrice = Convert.ToDouble(orderInfo[4]);
            
            if(cardNo > 7000 || cardNo < 5000)
            {
                MultiCellBuffer.OrderValid = false;
                return;
            }
            
            double totalPrice = amount * unitPrice;
        }
    }
}
