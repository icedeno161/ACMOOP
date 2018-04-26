using System;
using ACMOOP.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMOOP.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidProductTest()
        {
            //Arrange
            var product = new Product { ProductName = "Cake", CurrentPrice = 0 };
            var expected = true;

            //Act
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidProductNameTest()
        {
            //Arrange
            var product = new Product { CurrentPrice = 0 };
            var expected = false;

            //Act
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidCurrentPriceTest()
        {
            //Arrange
            var product = new Product { ProductName = "Cake" };
            var expected = false;

            //Act
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
