﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    class Payments : IOrder
    {
        public void processOrder()
        {
            Console.WriteLine("Generate a commision Payment to agent");
        }
    }
}