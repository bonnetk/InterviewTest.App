using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.App.Data
{
    /// <summary>
    /// I first thought I would create an order object to get list of items and their quantities
    /// the order could also be responsible for computing the total price of each item that has
    /// been added to the list because I'm not sure if it really has to be done directly inside the product.
    /// I decided to focus on the rest and abandoned this idea.
    /// </summary>
    class Order
    {
        ICollection<IProduct> Items;
    }
}
