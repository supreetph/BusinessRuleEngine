using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
   public class BooksOrder : IOrder
    {
        public void processOrder()
        {
            Console.WriteLine("Duplicate packing slip for royalty department Created");

        }
    }
}
