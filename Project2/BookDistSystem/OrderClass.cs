using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class OrderClass
    {
        private int senderId;   // Identity of sender, can use thread name or id
        private int cardNo;     // Credit card number
        private int receiverId; // Identity of receiever, can use thread name or unique name defined for publisher
        private int amount;     // Amount of books to order
        private int unitPrice;  // Price per unit of book

        public OrderClass(int senderId, int cardNo, int receiverId, int amount, int unitPrice){
            this.senderId = senderId;
            this.cardNo = cardNo;
            this.receiverId = receiverId;
            this.amount = amount;
            this.unitPrice = unitPrice;
        }

        public int getSenderId()
        {
            return this.senderId;
        }

        public int getCardNo()
        {
            return this.cardNo;
        }

        public int getReceiverId()
        {
            return this.receiverId;
        }

        public int getAmount()
        {
            return this.amount;
        }

        public int getUnitPrice()
        {
            return this.unitPrice;
        }

        public void setSenderId(int id)
        {
            senderId = id;
        }

        public void setCardNo(int no)
        {
            cardNo = no;
        }

        public void setReceieverId(int id)
        {
            receiverId = id;
        }

        public void setAmount(int num)
        {
            amount = num;
        }

        public void setUnitPrice(int price)
        {
            unitPrice = price;
        }


    }
}
