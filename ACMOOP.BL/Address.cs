using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL
{
    public class Address
    {
        #region Constructors

        public Address()
        {

        }

        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        #endregion

        #region Properties

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public CivicAddress CivicAddress { get; set; }

        #endregion

    }
}
