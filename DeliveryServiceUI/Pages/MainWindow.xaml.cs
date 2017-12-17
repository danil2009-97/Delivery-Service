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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(PageFactory.Instance.PageRepository.LoginPage);
            PageFactory.Instance.PageRepository.LoginPage.LoggedIn += NavigateToHome;
        }

        
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            PageFactory.Instance.PageRepository.HomePage.RefreshShopListBox();
            mainFrame.Navigate(PageFactory.Instance.PageRepository.HomePage);
            
        }

        private void NavigateToHome()
        {
            mainFrame.Navigate(PageFactory.Instance.PageRepository.HomePage);
            menuGrid.Visibility = Visibility.Visible;
            mainFrame.BorderThickness = new Thickness(3);
        }

        private void cartButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(PageFactory.Instance.PageRepository.CartPage);
        }

        private void ordersButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(PageFactory.Instance.PageRepository.OrderPage);
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(PageFactory.Instance.PageRepository.ProfilePage);
        }
    }
}
