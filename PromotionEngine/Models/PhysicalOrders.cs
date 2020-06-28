using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    class PhysicalOrders : IOrder
    {
       

        string IOrder.processOrder()
        {
            return "Packing slip Generated";
        }
    }
}
