using System;

namespace InterviewTest.App.Data
{
    public class Vegetable : Product
    {
        /// <summary>
        /// Creates a new Vegetable
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <param name="unitPrice"></param>
        public Vegetable(String name, int count, int unitPrice) : base(HealthIndex.Good) // Pass the HealIndex to the base class
        {
            Name = name;
            Count = count;
            UnitPrice = unitPrice;
        }
    }
}
