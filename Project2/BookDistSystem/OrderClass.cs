﻿using System;
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

        public OrderClass(){
            this.senderId = 0;
            this.cardNo = 0;
            this.receiverId = 0;
            this.amount = 0;
            this.unitPrice = 0;
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
