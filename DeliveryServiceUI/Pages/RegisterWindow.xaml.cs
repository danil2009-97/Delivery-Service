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
using System.Security.Cryptography;

namespace DeliveryServiceUI
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Methods methods = new Methods();
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            var res = MessageBox.Show("Отменить регистрацию?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
                Close();
        }

      

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            string phone = userPhoneTextBox.Text;
            long num;
            if (long.TryParse(phone, out num) && phone.Count() == 10)
            {
                User newUser = new User { Name = userNameTextBox.Text, Password = Methods.methods.CalculateHash(userPasswordBox.Password), Email = userEmailTextBox.Text, PhoneNumber = phone };
                MessageBox.Show("Вы успешно зарегистрировались", "Регистрация завершена", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
                
            else
                MessageBox.Show("Введите корректный номер", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
