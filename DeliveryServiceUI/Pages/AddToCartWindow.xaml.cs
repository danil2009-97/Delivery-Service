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
using System.Windows.Shapes;
using DeliveryServiceLogic;

namespace DeliveryServiceUI
{
    /// <summary>
    /// Логика взаимодействия для AddToCartWindow.xaml
    /// </summary>
    public partial class AddToCartWindow : Window
    {
        Product product;

        public AddToCartWindow(Product _product)
        {
            InitializeComponent();
            product = _product;
            DataContext = product;
            totalPriceTextBox.Text = product.Price.ToString();
            productQuantityTextBox.Text = "1";

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addToCartButton_Click(object sender, RoutedEventArgs e)
        {
            uint n;
            if (uint.TryParse(productQuantityTextBox.Text, out n))
            {
                var newproduct = new OrderedProduct
                {
                    Product = product,
                    Quantity = (int)n
                };
                Factory.Default.GetRepositoryCRUD<OrderedProduct>().AddItem(newproduct);
                //save to db
                Close();
            }
            else
                MessageBox.Show("Введите корректное значение количества", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void productQuantityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            uint n;
            if (uint.TryParse(productQuantityTextBox.Text, out n))
                totalPriceTextBox.Text = (n * product.Price).ToString();
            else
                totalPriceTextBox.Text = "";
        }
    }
}
