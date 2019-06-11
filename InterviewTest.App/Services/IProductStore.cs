using InterviewTest.App.Data;
using System;
using System.Collections.Generic;

namespace InterviewTest.App.Services
{
    /// <summary>
    /// Product repository
    /// </summary>
    public interface IProductStore
    {
        /// <summary>
        /// Method to get all the products
        /// </summary>
        /// <returns></returns>
        IEnumerable<IProduct> GetProducts();

        /// <summary>
        /// Method to get all product categories
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductCategory> GetProductCategories();

        /// <summary>
        /// Method to add a product
        /// </summary>
        /// <param name="product"></param>
        void AddProduct(IProduct product);

        /// <summary>
        /// Method to remove a product
        /// </summary>
        /// <param name="productId"></param>
        void RemoveProduct(Guid productId);

        //Let's assume we cannot update a product
        event Action<IProduct> ProductAdded;
        event Action<Guid> ProductRemoved;
    }
}
