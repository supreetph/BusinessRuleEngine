﻿using PromotionEngine.Controller;
using System;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter payment type");
            string ordertype = Console.ReadLine();
         
            OrderController or = new OrderController();
          var response=  or.ProcessOrder(ordertype);
            Console.WriteLine(response);

        }
    }
}
