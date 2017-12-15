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
using DeliveryServiceLogic;

namespace DeliveryServiceUI
{
    /// <summary>
    /// Логика взаимодействия для CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        List<OrderedProduct> oplist;
        public CartPage()
        {
            InitializeComponent();
            oplist = FillListBox();
            cartListBox.ItemsSource = oplist;
        }

        private List<OrderedProduct> FillListBox()
        {
            var p1 = new Product { Name = "Pizze", Price = 450, Type =  new ProductType { Name = "Пицца" }, Weight = 810 };
            var p2 = new Product { Name = "Cheese", Price = 299, Type = new ProductType { Name = "Сыр" }, Weight = 200 };
            var op1 = new OrderedProduct { Product = p1, Quantity = 2 };
            var op2 = new OrderedProduct { Product = p2, Quantity = 3 };
            return new List<OrderedProduct> { op1, op2 };
        }

        private void cartListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                var pr = cartListBox.SelectedItem as OrderedProduct;
                var res = MessageBox.Show($"Удалить {pr.Product.Name} из заказа?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (res == MessageBoxResult.Yes)
                {
                    oplist.Remove(pr);
                    cartListBox.ItemsSource = null;
                    cartListBox.ItemsSource = oplist;
                }
                else { }

            }
        }
      
    }
}
