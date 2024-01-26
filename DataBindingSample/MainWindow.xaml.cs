using DataBindingSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //konstruktor
            InitializeComponent();
            //datenkontext auf ein produkt setzen
            Product myProduct = new Product()
            {
                ProductId = 1,
                Price = 1,
                ProductName = "Test",
                Color = "Purple",
                Expired = true,
            };

            //myProduct = new Product();        ---zwei varienta ein produkt zu definieren
            //myProduct.ProductId = 2;
            //myProduct.Price = 2;
            //myProduct.Color = "red";
            //myProduct.Expired = false;

            this.DataContext = myProduct;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product myProduct = this.DataContext as Product;
            var currentPrice = myProduct.Price;

            myProduct.Price = currentPrice + 10;

        }
    }
}
