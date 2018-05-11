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

        #endregion
    }
}
