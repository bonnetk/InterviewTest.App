using System;

namespace InterviewTest.App.Data
{
    public class Fruit : Product
    {
        public Fruit(String name, int count, int unitPrice) : base(HealthIndex.Average)
        {
            Name = name;
            Count = count;
            UnitPrice = unitPrice;
        }
    }
}
