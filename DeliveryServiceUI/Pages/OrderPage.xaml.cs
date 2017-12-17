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

    }
}
