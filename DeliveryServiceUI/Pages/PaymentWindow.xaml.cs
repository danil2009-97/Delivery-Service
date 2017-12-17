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
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public event Action CloseParent;
        Methods _methods = new Methods();
       
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void cashPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш заказ оформлен (оплата при получении)", "Заказ оформлен", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
            CloseParent?.Invoke();
        }

        private void confirmPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckData())
            {
                MessageBox.Show("Оплата проведена успешно", "Заказ оформлен", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
                CloseParent?.Invoke();
                var newOrder = new Order
                {
                    OrderedTime = DateTime.Now,
                    DeliveredTime = DateTime.Now.Add(new TimeSpan(0, 10, 0)),
                    IsDelivered = false,
                    OrderedProducts = Factory.Default.GetRepositoryCRUD<OrderedProduct>().Data,
                    User = new User()
                };
                Factory.Default.GetRepositoryCRUD<Order>().AddItem(newOrder);
            }
            else
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool CheckData()
        {
            return (_methods.IsNumber(firstFourTextBox.Text, 4) && _methods.IsNumber(secondFourTextBox.Text, 4)
                && _methods.IsNumber(thirdFourTextBox.Text, 4) && _methods.IsNumber(fourthFourTextBox.Text, 4) && _methods.IsNumber(cvvTextBox.Text, 3));
        }

        
    }
}
