using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    public class Payments : IOrder
    {
        public string processOrder()
        {
           string response ="Generate a commision Payment to agent";
            return response;
        }
    }
}
