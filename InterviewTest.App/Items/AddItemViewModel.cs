using InterviewTest.App.Data;
using InterviewTest.App.Services;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTest.App.Items
{
    /// <summary>
    /// ViewModel to the view AddItem 
    /// Allows the user to add multiple types of items to the list
    /// </summary>
    class AddItemViewModel : BaseViewModel
    {
        /// <summary>
        /// Data repository for the ViewModel
        /// </summary>
        private IProductStore _repo;

        /// <summary>
        /// Product object
        /// </summary>
        private IProduct _product = null;
        public IProduct Product
        {
            get { return _product; }
            set { SetProperty(ref _product, value); }
        }

        /// <summary>
        /// Product categories
        /// </summary>
        private IEnumerable<ProductCategory> _productCategories;
        public IEnumerable<ProductCategory> ProductCategories
        {
            get { return _productCategories; }
            set {}
        }

        /// <summary>
        /// Command to add a new item to the list
        /// </summary>
        public RelayCommand AddCommand { get; private set; }

        public AddItemViewModel(IProductStore repo)
        {
            // Set the repository - Dependency injection
            _repo = repo;

            // Create the command - Command pattern
            AddCommand = new RelayCommand(OnAdd, CanAdd);

            // Set categories
            // Setting both the categories and products like this is not a good idea
            // Here it will perform everything synchronously. Having a lot of products
            // will cause the UI to freeze. I know there is a way to load the data async
            // but I don't have the time to do it..
            _productCategories = _repo.GetProductCategories();
        }

        /// <summary>
        /// Method use to add an item to the list, through the repo
        /// this is the reason why we need the reference to it
        /// </summary>
        private async void OnAdd()
        {
            // I tried to use an async method in order to avoid the UI thread to block

            // Add the current product to the list
            _repo.AddProduct(_product);
        }

        /// <summary>
        /// Check availability of the product before adding it ?
        // Could be a great Idea to it at this moment but I wasn't sure about the purpose of this method
        /// </summary>
        /// <returns></returns>
        private bool CanAdd()
        {
            return true;
        }
    }
}
