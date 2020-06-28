using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PromotionEngine.Models
{
    class Membership : IOrder
    {
        public string processOrder()
        {
            return "Membership Activated";

        }
    }
}
