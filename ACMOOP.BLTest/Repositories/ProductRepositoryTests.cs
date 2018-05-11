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
    public class ProductRepositoryTests
    {
        [TestMethod()]
        public void ProductRepositoryRetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Socks",
                Description = "Comfortable and breathable.",
                CurrentPrice = 2.99M
            };

            //Act
            var actual = productRepository.Retrieve(2);

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}