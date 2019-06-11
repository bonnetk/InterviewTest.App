using InterviewTest.App.Data;
using InterviewTest.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace InterviewTest.App.Items
{
    class ItemListViewModel
    {

        /// <summary>
        /// Data repository for the ViewModel
        /// </summary>
        private IProductStore _repo;

        /// <summary>
        /// List of products
        /// </summary>
        private readonly IEnumerable<IProduct> _products;
        public IEnumerable<IProduct> Products
        {
            get { return _products; }
        }

        public ItemListViewModel(IProductStore repo)
        {
            _products = _repo.GetProducts();

            // Create the command - Command pattern
            CheckAvailabilityCommand = new RelayCommand(OnCheckAvailability);

        }

        /// <summary>
        /// Command to check availability of product
        /// </summary>
        public RelayCommand CheckAvailabilityCommand { get; private set; }

        /// <summary>
        /// Method use to add an item to the list, through the repo
        /// this is the reason why we need the reference to it
        /// Async method to avoid to block the UI while acquiring the data
        /// </summary>
        private async void OnCheckAvailability()
        {
            List<ProductAvailabilityChecker> checkers = new List<ProductAvailabilityChecker>();
            List<Thread> t = new List<Thread>();
            foreach (IProduct p in _products)
            {
                ProductAvailabilityChecker productAvailabilityChecker = new ProductAvailabilityChecker(p);
                checkers.Add(productAvailabilityChecker);
                Thread thread = new Thread(productAvailabilityChecker.CheckIfAvailable);
                t.Add(thread);
                thread.Start();
            }
            foreach (Thread thread in t)
            {
                thread.Join();
            }

            StringBuilder sb = new StringBuilder();
            bool anyError = false;
            foreach (ProductAvailabilityChecker checker in checkers)
            {
                if (!checker.Result)
                {
                    anyError = true;
                    sb.AppendLine("The product " + checker.Product.Name + " is not available");
                }
            }
            if (!anyError)
            {
                // I explained a bit about the validation in the MainWindow.xaml
                // I'm not familiar with MessageBox but I think the ViewModel should notify the view about
                // the error and the view should display the message
                // The show method takes a Window as parameter
                MessageBox.Show(this, "Everything is available."); 
            }
            else
            {
                MessageBox.Show(this, sb.ToString());
            }
        }
    }
}
