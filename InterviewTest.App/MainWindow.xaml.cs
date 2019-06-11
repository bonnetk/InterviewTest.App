using InterviewTest.App.Data;
using InterviewTest.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace InterviewTest.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Code inside ths file : the less code the better
        // This file should only take care about the presentation

        
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validation - Must be done in the ViewModel not in the code behind !
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _unitprice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            e.Handled = !regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Validation - Must be done in the ViewModel not in the code behind !
        /// I know we can use the annotation to perform some validation and also
        /// the mechanism of INotifyDataErrorInfo to display error in the views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _quantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            e.Handled = !regex.IsMatch(e.Text);
        }

        /// <summary>
        /// This should be done in the ViewModel and not in the code behind !
        /// I get the purpose of this method but I think that if the application is
        /// correctly built, using the mechanism of INotifyPropertyChanged, the information 
        /// could be reloaded in a more proper way, or in a more automated way
        /// </summary>
        private void RefreshProducts()
        {
            _productList.Items.Clear();
            foreach (IProduct product in _products)
            {
                _productList.Items.Add(product);
            }
        }

        /// <summary>
        /// Same comment as the previous method
        /// </summary>
        /// <param name="obj"></param>
        private void _productStore_ProductRemoved(Guid obj)
        {
            IProduct possibleProduct = _products.FirstOrDefault(p => p.Id == obj);
            if (possibleProduct != null)
            {
                _products.Remove(possibleProduct);
                RefreshProducts();
            }
        }

        /// <summary>
        /// Same comment as the previous method
        /// </summary>
        /// <param name="obj"></param>
        private void _productStore_ProductAdded(IProduct obj)
        {
            _products.Add(obj);
            RefreshProducts();
        }
    }
}
