using DemoLibrary;
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

namespace WpfMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                AddressModel address = new AddressModel
                {
                    StreetAddress = streetAddressText.Text,
                    City = cityText.Text,
                    State = stateText.Text,
                    ZipCode = zipCodeText.Text,
                };
                _parent.SaveAddress(address);
                Close();
            }
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(streetAddressText.Text) && !string.IsNullOrWhiteSpace(cityText.Text)
                && !string.IsNullOrWhiteSpace(stateText.Text) && !string.IsNullOrWhiteSpace(zipCodeText.Text);
        }
    }
}
