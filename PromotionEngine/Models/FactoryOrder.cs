using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace PromotionEngine.Models
{
    class FactoryOrder
    {
        static public IOrder GetOrder(string orderType)
        {
            IOrder objIorder;
            if(orderType.Equals("Membership"))
            {
                objIorder = new Membership();

            }
            return objIorder;
        }
    }
}
