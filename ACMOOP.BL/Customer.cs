using System;
using System.Collections.Generic;
using System.Device.Location;

namespace ACMOOP.BL
{
    public class Customer
    {
        #region Constructors

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }
        #endregion

        #region Properties

        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public CivicAddress HomeAddress { get; set; }
        public CivicAddress WorkAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }
                return fullName;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Validates whether the Customer data is valid.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Returns the Customer with the provided customer id.
        /// </summary>
        /// <param name="customerId">Id of customer to retrieve.</param>
        /// <returns></returns>
        public Customer Retrieve(int customerId) => new Customer();

        /// <summary>
        /// Retrieves a list of all Customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve() => new List<Customer>();

        /// <summary>
        /// Returns whether the customer was saved successfully.
        /// </summary>
        /// <returns></returns>
        public bool Save() => true;

        #endregion
    }
}
