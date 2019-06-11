using System;

namespace InterviewTest.App.Data
{
    public interface IProduct
    {
        Guid Id { get; }
        String Name { get; set; }
        int Count { get; set; }
        int UnitPrice { get; set; }
        int TotalPrice { get; }
        string Category { get; set; } // Product Category
        HealthIndex HealthIndex { get; }
    }
}
