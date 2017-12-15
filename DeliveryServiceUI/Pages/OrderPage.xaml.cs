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
            ordersListBox.ItemsSource = new List<Order> { new Order { DeliveredTime = DateTime.Now, OrderedTime = DateTime.Now, IsDelivered = false }, new Order { DeliveredTime = DateTime.Now, OrderedTime = DateTime.Now, IsDelivered = true } };
        }
    }
}
