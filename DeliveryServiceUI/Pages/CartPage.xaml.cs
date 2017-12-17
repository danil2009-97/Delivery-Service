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
        
        public CartPage()
        {
            InitializeComponent();
            RefreshListBox();
        }              

        private void cartListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                var pr = cartListBox.SelectedItem as OrderedProduct;
                var res = MessageBox.Show($"Удалить {pr.Product.Name} из заказа?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (res == MessageBoxResult.Yes)
                {
                    Factory.Default.GetRepositoryCRUD<OrderedProduct>().RemoveItem(pr);
                    RefreshListBox();
                }
                else { return; }
            }
        }

        public void RefreshListBox()
        {
            cartListBox.ItemsSource = null;
            cartListBox.ItemsSource = Factory.Default.GetRepositoryCRUD<OrderedProduct>().Data;
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            var mapWindow = new MapWindow();
            mapWindow.ShowDialog();
        }
    }
}
