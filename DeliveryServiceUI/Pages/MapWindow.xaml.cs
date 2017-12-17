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
using BingMapsRESTToolkit;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Design;
using DeliveryServiceLogic;

namespace DeliveryServiceUI
{
    /// <summary>
    /// Interaction logic for MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        Pushpin currentPushpin = new Pushpin();
        LocationConverter locConverter = new LocationConverter();
        GeocodeHelper gh = new GeocodeHelper();

        public MapWindow()
        {
            InitializeComponent();
            myMap.Focus();
        }

        private void MapWithPushpins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            myMap.Children.Remove(currentPushpin);
            // Disables the default mouse double-click action.
            e.Handled = true;

            // Determin the location to place the pushpin at on the map.

            //Get the mouse click coordinates
            System.Windows.Point mousePosition = e.GetPosition(this);

            //Convert the mouse coordinates to a locatoin on the map
            var pinLocation = myMap.ViewportPointToLocation(mousePosition);
            string test = pinLocation.ToString();           

            AddressResult ar = gh.GetAddress(test);           
            cityTextBox.Text = ar.Locality;
            addressTextBox.Text = ar.AddressLine;

            // The pushpin to add to the map.
            currentPushpin.Location = pinLocation;

            // Adds the pushpin to the map.
            myMap.Children.Add(currentPushpin);
        }

        private void confirmAddressButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести город", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                cityTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести адрес доставки", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                addressTextBox.Focus();
                return;
            }

            int n;
            if (!int.TryParse(flatTextBox.Text, out n))
            {
                MessageBox.Show("Необходимо ввести номер квартиры", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                addressTextBox.Focus();
                return;
            }
            if (cityTextBox.Text != "Moscow" && cityTextBox.Text != "Москва")
            {
                MessageBox.Show("К сожалению, мы работаем только в Москве(Moscow)", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                cityTextBox.Focus();
                return;
            }

                var pay = new PaymentWindow();
                pay.CloseParent += this.Close;
                pay.CloseParent += PageFactory.Instance.PageRepository.CartPage.RefreshListBox;
                pay.ShowDialog();
        }
    }
}
