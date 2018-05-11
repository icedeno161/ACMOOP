using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACMOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL.Tests
{
    [TestClass()]
    public class CustomerRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = "Cedeno, Ivan";

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected, actual.FullName);
        }
    }
}