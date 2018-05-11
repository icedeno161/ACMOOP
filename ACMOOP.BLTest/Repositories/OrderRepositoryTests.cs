using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMOOP.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL.Repositories.Tests
{
    [TestClass()]
    public class OrderRepositoryTests
    {
        [TestMethod()]
        public void OrderRetrieveTest()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //Act
            var actualDate = orderRepository.Retrieve(10).OrderDate;

            //Assert
            Assert.AreEqual(expected.OrderDate, actualDate);
        }
    }
}
