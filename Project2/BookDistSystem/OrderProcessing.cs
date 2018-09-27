using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BookDistSystem
{
    public delegate void orderProcessedEvent();
    public class OrderProcessing
    {
        public static event orderProcessedEvent orderProcessed;
        public int totalOrdersProcessed = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        public OrderProcessing()
        {

        }

        /// <summary>
        /// Order Processing Thread method spawned by publisher
        /// </summary>
        /// <param name="orderInfo"></param>
        /// <param name="publisher"></param>
        public void Process(string[] orderInfo, int publisher)
        {
            //simulate work
            (Application.OpenForms[0] as MainForm).setOrderProcessing("Order Processing", publisher - 1);
            Thread.Sleep(2000);
            //convert strings into usable integers
            int senderID = Convert.ToInt32(orderInfo[0]);
            int cardNo = Convert.ToInt32(orderInfo[1]);
            int recvrID = Convert.ToInt32(orderInfo[2]);
            int amount = Convert.ToInt32(orderInfo[3]);
            double unitPrice = Convert.ToDouble(orderInfo[4]);
            if(cardNo > 7000 || cardNo < 5000)
            {
                (Application.OpenForms[0] as MainForm).setOrderProcessing("Invalid Card Number", publisher - 1);
                Thread.Sleep(2000);
                (Application.OpenForms[0] as MainForm).setOrderProcessing(" ", publisher - 1);
                return;
            }
            totalOrdersProcessed++;
            (Application.OpenForms[0] as MainForm).setNumOrders(totalOrdersProcessed);
            //raise event in the bookstore
            orderProcessed?.Invoke();
            double totalPrice = amount * unitPrice;
            (Application.OpenForms[0] as MainForm).setOrderProcessing("Valid Order Processed", publisher - 1);
            Thread.Sleep(2000);
            (Application.OpenForms[0] as MainForm).setOrderProcessing(" ", publisher - 1);
            (Application.OpenForms[0] as MainForm).setPrice(totalPrice);
        }
    }
}
