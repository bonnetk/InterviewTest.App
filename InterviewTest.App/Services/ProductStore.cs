using InterviewTest.App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTest.App.Services
{
    /// <summary>
    /// Product Repository
    /// </summary>
    public class ProductStore : IProductStore
    {
        /// <summary>
        /// Object to lock the list in order to avoid concurrency issues
        /// </summary>
        private readonly object _productsLock = new object();
        private readonly List<IProduct> _products = new List<IProduct>();
        private readonly List<ProductCategory> _productCategories = new List<ProductCategory>();

        /// <summary>
        /// Returns the products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IProduct> GetProducts()
        {
            return _products;
        }

        /// <summary>
        /// Returns the product categories
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductCategory> IProductStore.GetProductCategories()
        {
            return _productCategories.ToList();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductStore()
        {
            //NOTE: NO NEED TO CHANGE THIS; 
            _products.AddRange(new IProduct[]
            {
                new Fruit("Orange", 5,3),
                new Vegetable("Salad", 3,6)
            });
        }

        /// <summary>
        /// Add a product to the list
        /// </summary>
        /// <param name="product"></param>
        void IProductStore.AddProduct(IProduct product)
        {
            Thread.Sleep(5000);//DO NOT REMOVE; TO SIMULATE A BUGGY/SLOW SERVICE
            
            // Use the lock object to avoid concurrency issues
            lock (_productsLock)
            {
                _products.Add(product);
            }

            ProductAdded?.Invoke(product);
        }

        /// <summary>
        /// Removes a product from the list
        /// </summary>
        /// <param name="productId"></param>
        void IProductStore.RemoveProduct(Guid productId)
        {
            Thread.Sleep(5000);//DO NOT REMOVE; TO SIMULATE A BUGGY/SLOW SERVICE
            IProduct product = _products.FirstOrDefault(p => p.Id.Equals(productId));
            if (product != null)
            {
                // Use the lock object to avoid concurrency issues
                lock (_productsLock)
                {
                    _products.Remove(product);
                }
                ProductRemoved?.Invoke(productId);
            }
        }

        public event Action<IProduct> ProductAdded;
        public event Action<Guid> ProductRemoved;
    }
}
