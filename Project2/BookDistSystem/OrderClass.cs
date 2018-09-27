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
        private double unitPrice;  // Price per unit of book

        /// <summary>
        /// Constructor
        /// </summary>
        public OrderClass(){
            senderId = 0;
            cardNo = 0;
            receiverId = 0;
            amount = 0;
            unitPrice = 0;
        }

        /// <summary>
        /// senderID getter
        /// </summary>
        /// <returns>int</returns>
        public int getSenderId()
        {
            return this.senderId;
        }

        /// <summary>
        /// cardNo getter
        /// </summary>
        /// <returns>int</returns>
        public int getCardNo()
        {
            return this.cardNo;
        }

        /// <summary>
        /// ReceiverId getter
        /// </summary>
        /// <returns>int</returns>
        public int getReceiverId()
        {
            return this.receiverId;
        }

        /// <summary>
        /// Amount getter
        /// </summary>
        /// <returns>int</returns>
        public int getAmount()
        {
            return this.amount;
        }

        /// <summary>
        /// unitprice getter
        /// </summary>
        /// <returns>double</returns>
        public double getUnitPrice()
        {
            return this.unitPrice;
        }

        /// <summary>
        /// senderId set method
        /// </summary>
        /// <param name="id"></param>
        public void setSenderId(int id)
        {
            senderId = id;
        }

        /// <summary>
        /// card number set method
        /// </summary>
        /// <param name="no"></param>
        public void setCardNo(int no)
        {
            cardNo = no;
        }

        /// <summary>
        /// Receiver ID set method
        /// </summary>
        /// <param name="id"></param>
        public void setReceieverId(int id)
        {
            receiverId = id;
        }

        /// <summary>
        /// Book amount set method
        /// </summary>
        /// <param name="num"></param>
        public void setAmount(int num)
        {
            amount = num;
        }

        /// <summary>
        /// Unit price set method
        /// </summary>
        /// <param name="price"></param>
        public void setUnitPrice(double price)
        {
            unitPrice = price;
        }


    }
}
