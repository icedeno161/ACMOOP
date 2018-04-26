using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL.BLTest
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void ValidOrderTest()
        {
            //Arrange
            var order = new Order { OrderDate = DateTimeOffset.Now };
            var expected = true;

            //Act
            var actual = order.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void InvalidOrderTest()
        {
            //Arrange
            var order = new Order();
            var expected = false;

            //Act
            var actual = order.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}