﻿using System;
using ACMOOP.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMOOP.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ivan";
            customer.LastName = "Cedeno";
            var expected = "Cedeno, Ivan";

            //Act
            var FullName = customer.FullName;

            //Assert
            Assert.AreEqual(expected, FullName);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Cedeno";
            var expected = "Cedeno";

            //Act
            var FullName = customer.FullName;

            //Assert
            Assert.AreEqual(expected, FullName);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ivan";
            var expected = "Ivan";

            //Act
            var FullName = customer.FullName;

            //Assert
            Assert.AreEqual(expected, FullName);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer { FirstName = "Bilbo" };
            Customer.InstanceCount++;

            var c2 = new Customer { FirstName = "Frodo" };
            Customer.InstanceCount++;

            var c3 = new Customer { FirstName = "Rosie" };
            Customer.InstanceCount++;

            var expected = 3;

            //Act
            var actual = Customer.InstanceCount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerIsValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Cedeno",
                EmailAddress = "icedeno@unicefusa.org"
            };
            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerEmailIsNotValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Cedeno",
                EmailAddress = ""
            };
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerLastNameIsNotValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "",
                EmailAddress = "icedeno@unicefusa.org"
            };
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
