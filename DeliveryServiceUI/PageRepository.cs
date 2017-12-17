using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceUI
{
    public class PageRepository
    {
        private LoginPage _loginPage;
        private HomePage _homePage;
        private CartPage _cartPage;
        private OrderPage _orderPage;
        private ProfilePage _profilePage;

        public LoginPage LoginPage
        {
            get { return _loginPage ?? (_loginPage = new LoginPage()); }
        }

        public HomePage HomePage
        {
            get { return _homePage ?? (_homePage = new HomePage()); }
        }

        public CartPage CartPage
        {
            get { return _cartPage ?? (_cartPage = new CartPage()); }
        }

        public OrderPage OrderPage
        {
            get { return _orderPage ?? (_orderPage = new OrderPage()); }
        }

        public ProfilePage ProfilePage
        {
            get { return _profilePage ?? (_profilePage = new ProfilePage()); }
        }
    }
}
