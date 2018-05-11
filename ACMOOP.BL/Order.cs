using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL
{
    public class Order
    {
        #region Constructors

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        #endregion

        #region Properties

        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public Address ShippingAddress { get; set; }
        public List<OrderItem> ProductsOrdered { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns whether the order is valid.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        #endregion
    }
}
