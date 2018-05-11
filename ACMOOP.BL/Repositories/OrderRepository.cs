using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL.Repositories
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieves an order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

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
    }
}
