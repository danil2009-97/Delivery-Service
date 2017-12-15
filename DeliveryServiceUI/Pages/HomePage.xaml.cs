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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        List<Shop> shopList;

        public HomePage()
        {
            InitializeComponent();
            shopList = FillTheListBoxBitch();
            shopCategoriesComboBox.ItemsSource = FillTypesPlsThx();
            sortComboBox.ItemsSource = SortList();
            RefreshShopListBox();
        }

        public void RefreshShopListBox()
        {
            assortmentListBox.ItemsSource = shopList;
        }

        private List<Shop> FillTheListBoxBitch()
        {
            var shops = new List<Shop>
            {
                new Shop{Name="CarloPesto", /*LogoPath="Images/preview.jpg"*/ Rating=4, Type="Итальянский шлак", AvgCheck=700},
                new Shop{Name="La'Perie DeNavaln'ie", /*LogoPath="Images/logo_small.jpg"*/ Rating =4.5, Type="Лягушки", AvgCheck=1200 },
            };
            return shops;
        }

        private List<string> FillTypesPlsThx()
        {
            var lstr = new List<string> { "Мексика", "Суши"};
            return lstr;
        }

        private List<string> SortList()
        {
            return new List<string> { "по рейтингу", "по цене (убыв.)", "по цене(возр.)", "по среднему чеку" };
        }

        private void assortmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void assortmentListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (assortmentListBox.SelectedItem is Shop)
            {
                assortmentListBox.ItemsSource = new List<Product>
                {
                    new Product{Name="Pizze", Price=450, Type="Пицца", Weight=810},
                    new Product{Name="Cheese", Price=299, Type="Сыр", Weight=200},
                    new Product{Name="Бургер", Price=24523452345, Type="ФастФуд", Weight=13}
                };
            }
            else
            {
                var pr = (Product)assortmentListBox.SelectedItem;
                var addWindow = new AddToCartWindow(pr);
                addWindow.ShowDialog();
            }
        }
    }
}
