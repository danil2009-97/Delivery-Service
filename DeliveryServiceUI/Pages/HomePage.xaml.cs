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

        IRepository<Product> productRepo = Factory.Default.GetRepository<Product>();
        IRepository<Shop> shopRepo = Factory.Default.GetRepository<Shop>();

        public HomePage()
        {
            InitializeComponent();
            shopCategoriesComboBox.ItemsSource = FillTypesPlsThx();
            sortComboBox.ItemsSource = SortList();
            assortmentListBox.ItemsSource = shopRepo.Data;
        }

        public void RefreshShopListBox()
        {
            assortmentListBox.ItemsSource = shopList;
        }

        private List<Shop> FillTheListBox()
        {
            var shops = new List<Shop>
            {
                new Shop{Name="CarloPesto", LogoPath="/Images/search.png", Rating = 4, Type = new ShopType{ Name = "Итальянская еда" }, AvgCheck=700},
                new Shop{Name="La'Perie DeNavaln'ie", LogoPath="/Images/search.png", Rating = 4.5, Type= new ShopType{ Name = "Французская еда" }, AvgCheck=1200 },
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
                assortmentListBox.ItemsSource = productRepo.Data;
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
