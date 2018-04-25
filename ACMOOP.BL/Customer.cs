using System;
using System.Device.Location;

namespace ACMOOP.BL
{
    public class Customer
    {
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
    }
}
