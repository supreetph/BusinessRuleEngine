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
            string ordertype = "Member";
           
            OrderController order = new OrderController();
            var expectedResponse = "Membership Activated";
            Assert.AreEqual(expectedResponse,
                            order.ProcessOrder(ordertype));



        }
    }
}
