using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL
{
    public class OrderItem
    {
        #region Properties

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int MyProperty { get; set; }

        #endregion
    }
}
