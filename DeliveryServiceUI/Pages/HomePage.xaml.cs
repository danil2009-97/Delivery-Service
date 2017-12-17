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

        IRepository<Product> productRepo = Factory.Default.GetRepository<Product>();
        IRepository<Shop> shopRepo = Factory.Default.GetRepository<Shop>();
        IRepository<ShopType> shopTypeRepo = Factory.Default.GetRepository<ShopType>();
        IRepository<ProductType> productTypeRepo = Factory.Default.GetRepository<ProductType>();

        public HomePage()
        {
            InitializeComponent();
            shopCategoriesComboBox.ItemsSource = shopTypeRepo.Data;
            sortComboBox.ItemsSource = SortList();
            currentShops = shopRepo.Data;
            assortmentListBox.ItemsSource = currentShops;
        }

        public void RefreshShopListBox()
        {
            currentShops = shopRepo.Data;
            assortmentListBox.ItemsSource = currentShops;            
            shopCategoriesComboBox.ItemsSource = shopTypeRepo.Data;
            shopCategoriesComboBox.SelectedIndex = -1;
            sortComboBox.Visibility = Visibility.Visible;
            searchTextBox.Visibility = Visibility.Visible;
            sortTextBlock.Visibility = Visibility.Visible;
            searchTextBox.Text = "";
        }


        private List<string> SortList()
        {
            return new List<string> { "по рейтингу", "по среднему чеку (убыв.)", "по среднему чеку (возр.)" };
        }

        private void assortmentListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (assortmentListBox.SelectedItem is Shop)
            {
                chosenShop = assortmentListBox.SelectedItem as Shop;
                assortmentListBox.ItemsSource = chosenShop.Products;
                shopCategoriesComboBox.ItemsSource = productTypeRepo.Data;
                sortComboBox.Visibility = Visibility.Hidden;
                searchTextBox.Visibility = Visibility.Hidden;
                sortTextBlock.Visibility = Visibility.Hidden;
            }
            else if (assortmentListBox.SelectedItem is Product)
            {
                var pr = (Product)assortmentListBox.SelectedItem;
                var addWindow = new AddToCartWindow(pr);
                addWindow.ShowDialog();
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = searchTextBox.Text.ToLower();
            if (text == "")
                assortmentListBox.ItemsSource = shopRepo.Data;
            else
                assortmentListBox.ItemsSource = shopRepo.FindAll(p => p.Name.ToLower().Contains(text));
        }

        private void shopCategoriesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (shopCategoriesComboBox.SelectedIndex != -1)
            {
                var selected = shopCategoriesComboBox.SelectedItem;
                if (selected is ShopType)
                {
                    var shopSelected = shopCategoriesComboBox.SelectedItem as ShopType;
                    assortmentListBox.ItemsSource = null;
                    currentShops = shopRepo.FindAll(p => p.Type.Name == shopSelected.Name).ToList();
                    FillListBox();
                }
                else if (selected is ProductType)
                {
                    var productSelected = shopCategoriesComboBox.SelectedItem as ProductType;
                    var products = chosenShop.Products;
                    assortmentListBox.ItemsSource = products.FindAll(p => p.Type.Name == productSelected.Name);
                }
            }
            else
            {
                currentShops = shopRepo.Data;
                if (shopCategoriesComboBox.ItemsSource is IEnumerable<ShopType>)
                    assortmentListBox.ItemsSource = currentShops;
                else
                    assortmentListBox.ItemsSource = chosenShop.Products;
            }
        }

        Shop chosenShop = null;
        IEnumerable<Shop> currentShops;

        private void dropFilterBtn_Click(object sender, RoutedEventArgs e)
        {
            shopCategoriesComboBox.SelectedIndex = -1;
            sortComboBox.SelectedIndex = -1;
            searchTextBox.Text = "";
        }

        private void FillListBox()
        {
            int ind = sortComboBox.SelectedIndex;
            if (ind == 0)
            {
                var newShopList = currentShops.OrderByDescending(p => p.Rating).ToList();
                assortmentListBox.ItemsSource = newShopList;
            }
            if (ind == 1)
            {
                var newShopList = currentShops.OrderByDescending(p => p.AvgCheck).ToList();
                assortmentListBox.ItemsSource = newShopList;
            }
            if (ind == 2)
            {
                var newShopList = currentShops.OrderBy(p => p.AvgCheck).ToList();
                assortmentListBox.ItemsSource = newShopList;
            }
            if (ind == -1)
            {
                if (shopCategoriesComboBox.ItemsSource is IEnumerable<ShopType>)
                {
                    //currentShops = shopRepo.Data;
                    assortmentListBox.ItemsSource = currentShops;
                }
                else
                    assortmentListBox.ItemsSource = chosenShop.Products;
            }
        }

        private void sortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillListBox();
        }
    }
}
