using System;

namespace InterviewTest.App.Data
{
    /// <summary>
    /// Abstract class that implements the IProduct interface
    /// </summary>
    public abstract class Product : IProduct
    {
        /// <summary>
        /// Product ID
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// How many items
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Unit price
        /// </summary>
        public int UnitPrice { get; set; }

        /// <summary>
        /// Heath index of the product
        /// </summary>
        public HealthIndex HealthIndex { get; }

        /// <summary>
        /// Returns the total price of the product
        /// </summary>
        public int TotalPrice
        {
            get { return UnitPrice * Count; }
        }

        /// <summary>
        /// Category
        /// </summary>
        public string Category { get ; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="helthIndex"></param>
        public Product(HealthIndex helthIndex)
        {
            HealthIndex = HealthIndex;
            Id = new Guid();
        }
    }
}
