using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Controller;

namespace OrderTesting
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void TestMemberOrders()
        {
            string ordertype = "Membership";
           
            OrderController order = new OrderController();
            var expectedResponse = "Membership Activated";
            var actualResponse = order.ProcessOrder(ordertype);
            Assert.AreEqual(expectedResponse, actualResponse
                            );



        }
        public void TestBooksOrders()
        {
            string ordertype = "Books";

            OrderController order = new OrderController();
            var expectedResponse = "Duplicate packing slip for royalty department Created";
            var actualResponse = order.ProcessOrder(ordertype);
            Assert.AreEqual(expectedResponse, actualResponse
                            );



        }
        public void TestLearningOrders()
        {
            string ordertype = "Learning";

            OrderController order = new OrderController();
            var expectedResponse = "Free FirstAid Video added to Packing slip";
            var actualResponse = order.ProcessOrder(ordertype);
            Assert.AreEqual(expectedResponse, actualResponse
                            );



        }
    }
}
