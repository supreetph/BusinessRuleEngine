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
         public string  ProcessOrder(string orderType)
        {
            orderObj = FactoryOrder.GetOrder(orderType);
           return  orderObj.processOrder();
            
        }
    }
}
