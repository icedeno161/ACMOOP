using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL
{
    public class Product
    {
        #region Constructors

        public Product()
        {
                
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        #endregion

        #region Properties

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        #endregion

        #region Methods

        

        /// <summary>
        /// Validates whether the Product data is valid.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Overrides the Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var product = obj as Product;

            return (ProductId == product.ProductId) 
                && (ProductName == product.ProductName) 
                && (Description == product.Description) 
                && (CurrentPrice == product.CurrentPrice);
        }

        /// <summary>
        /// Overrides the GetHashCode method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return ProductId.GetHashCode() ^ ProductName.GetHashCode() ^ Description.GetHashCode() ^ CurrentPrice.GetHashCode();
        }

        #endregion
    }
}
