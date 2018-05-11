using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL
{
    public class CustomerRepository
    {
        #region Methods

        /// <summary>
        /// Returns the Customer with the provided customer id.
        /// </summary>
        /// <param name="customerId">Id of customer to retrieve.</param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "icedeno@unicefusa.org";
                customer.FirstName = "Ivan";
                customer.LastName = "Cedeno";
            }

            return customer;
        }

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
