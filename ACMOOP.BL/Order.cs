﻿using System;
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
        public CivicAddress ShippingAddress { get; set; }
        public List<OrderItem> ProductsOrdered { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Rerieves an order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId) => new Order();

        /// <summary>
        /// Retrieves the orders.
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve() => new List<Order>();

        /// <summary>
        /// Saves the order.
        /// </summary>
        /// <returns></returns>
        public bool Save() => true;

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
