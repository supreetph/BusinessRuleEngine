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
    }
}
