﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    class Membership : IOrder
    {
        public void processOrder()
        {
            Console.WriteLine("Membership Activated");
        }
    }
}
