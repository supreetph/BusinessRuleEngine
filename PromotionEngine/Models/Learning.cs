using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    class Learning : IOrder
    {
        

        string IOrder.processOrder()
        {
            return "Free FirstAid Video added to Packing slip";
        }
    }
}
