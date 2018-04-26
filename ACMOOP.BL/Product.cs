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
        /// Retrieves the product by product id.
        /// </summary>
        /// <param name="productId">id of product to retrieve.</param>
        /// <returns></returns>
        public Product Retrieve(int productId) => new Product();

        /// <summary>
        /// Retrieve a list of products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve() => new List<Product>();

        /// <summary>
        /// Returns whether saving is successful.
        /// </summary>
        /// <returns></returns>
        public bool Save() => true;

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

        #endregion
    }
}
