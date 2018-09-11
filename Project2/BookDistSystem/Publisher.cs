﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDistSystem
{
    public class Publisher
    {
        private int numPriceCuts = 0;
        
        OrderEvent order = new OrderEvent();
        public Publisher()
        {
            
        }

        /// <summary>
        /// method to be called by main as a thread
        /// </summary>
        public void Start()
        {
            order.orderEvent += Order_orderEvent;
        }

        private void Order_orderEvent()
        {
            
        }

        public int PricingModel(int orderAmount)
        {
            Random rnd = new Random();
            int price = rnd.Next(50, 201);

            if(orderAmount > 10 && orderAmount <= 20)
            {
                //price cut
                price = price - 5;
                numPriceCuts++;
            }
            else if(orderAmount > 20 && orderAmount <= 30)
            {
                //price cut
                price = price - 10;
                numPriceCuts++;
            }
            else if(orderAmount > 30)
            {
                //price cut
                price = price - 15;
                numPriceCuts++;
            }
            else
            {
                //no price cut, do nothing, less than 10 orders
            }

            return price;
        }
    }
}