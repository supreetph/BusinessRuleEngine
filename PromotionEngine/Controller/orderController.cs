using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PromotionEngine.Controller
{
  public class OrderController
    {
        IOrder orderObj;
         public void  ProcessOrder(string orderType)
        {
            orderObj = FactoryOrder.GetOrder(orderType);
            orderObj.processOrder();
            
        }
    }
}
