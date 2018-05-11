using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMOOP.BL.Repositories
{
    public class ProductRepository
    {
        #region Methods

        /// <summary>
        /// Retrieves the product by product id.
        /// </summary>
        /// <param name="productId">id of product to retrieve.</param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Socks";
                product.Description = "Comfortable and breathable.";
                product.CurrentPrice = 2.99M;
            }

            return product;
        }

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

        #endregion
    }
}
