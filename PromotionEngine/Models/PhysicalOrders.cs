using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    class PhysicalOrders : IOrder
    {
        public void processOrder()
        {
            Console.WriteLine("Packing slip Generated");
        }
    }
}
