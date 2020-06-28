using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace PromotionEngine.Models
{
   public class FactoryOrder
    {
        static public IOrder GetOrder(string orderType)
        {
            IOrder objIorder;
            if(orderType.Equals("Membership"))
            {
                objIorder = new Membership();

            }
            else if (orderType.Equals("Physical products"))
            {
                objIorder = new PhysicalOrders();

            }
            else if (orderType.Equals("Learning"))
            {
                objIorder = new Learning();

            }
            else if (orderType.Equals("Physical products")||orderType.Equals("Books"))
            {
                objIorder = new Payments();

            }
            else if (orderType.Equals("Books"))
            {
                objIorder = new BooksOrder();

            }

            else
            {
                return null;
            }
            return objIorder;
        }
    }
}
