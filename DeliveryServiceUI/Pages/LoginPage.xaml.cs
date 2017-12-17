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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        IEnumerable<User> userRepo = Factory.Default.GetRepositoryCRUD<User>().Data;
        public LoginPage()
        {
            InitializeComponent();
        }

        public event Action LoggedIn;

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            bool isLoginned = false;
            var email = txtEmail.Text;
            var password = Methods.methods.CalculateHash(txtPassword.Password);
            
            foreach (var item in userRepo)
            {
                if (item.Password == password && item.Email == email)
                {
                    isLoginned = true;
                }
            }
            if (isLoginned)
            {
                LoggedIn?.Invoke();
            }
            else
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            var regWin = new RegisterWindow();
            regWin.ShowDialog();
        }
    }
}
