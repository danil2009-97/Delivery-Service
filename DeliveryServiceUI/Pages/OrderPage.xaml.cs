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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            RefreshListBox();
        }
                

        public void RefreshListBox()
        {
            ordersListBox.ItemsSource = null;
            ordersListBox.ItemsSource = Factory.Default.GetRepositoryCRUD<Order>().Data.FindAll(o => o.UserId == Factory.Default.LoggedUser.Id).OrderByDescending(o => o.OrderedTime);
        }

        private void ordersListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ordersListBox.SelectedIndex != -1)
            {
                var ord = ordersListBox.SelectedItem as Order;
                var res = MessageBox.Show($"Удалить заказ?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (res == MessageBoxResult.Yes)
                {
                    Factory.Default.GetRepositoryCRUD<Order>().RemoveItem(ord);
                    RefreshListBox();
                }
                else { return; }
            }
        }
    }
}
