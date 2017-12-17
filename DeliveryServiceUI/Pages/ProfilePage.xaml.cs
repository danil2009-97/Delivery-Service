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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            DataContext = Factory.Default.LoggedUser;
            userPasswordBox.Password = Factory.Default.LoggedUser.Password;
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            var s1 = userNameTextBox.Text;
            var s2 = userPasswordBox.Password;
            var s3 = userPhoneTextBox.Text;
            if (s1!="" && s2!=""&& Methods.methods.IsNumber(s3, 10))
            {
                Factory.Default.LoggedUser.Name = s1;
                Factory.Default.LoggedUser.Password = Methods.methods.CalculateHash(s2);
                Factory.Default.LoggedUser.PhoneNumber = s3;
                (Factory.Default.GetRepositoryCRUD<User>() as UserRepo).UpdateUser(Factory.Default.LoggedUser);
                MessageBox.Show("Изменения сохранены", "Изменено", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void userPasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            userPasswordBox.Password = "";
        }

        private void userPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (userPasswordBox.Password == "")
                userPasswordBox.Password = Factory.Default.LoggedUser.Password;
        }
    }
}
