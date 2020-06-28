using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    class Learning : IOrder
    {
        public void processOrder()
        {
            Console.WriteLine("Free FirstAid Video added to Packing slip");
        }
    }
}
