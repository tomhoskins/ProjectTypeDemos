using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for PersonEntry.xaml
    /// </summary>
    public partial class PersonEntry : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        ISavePerson _parent;
        PersonModel? _person = null;
        public PersonEntry(ISavePerson parent)
        {
            InitializeComponent();
            _parent = parent;
            addressesList.ItemsSource = addresses;
        }

        public PersonEntry(ISavePerson parent, PersonModel person)
        {
            InitializeComponent();
            _parent = parent;
            addressesList.ItemsSource = addresses;
            _person = person;
            firstNameText.Text = person.FirstName;
            lastNameText.Text = person.LastName;
            isActiveCheck.IsChecked = person.IsActive;
            foreach (var address in person.Addresses) 
            {
                addresses.Add(address);
            }
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                PersonModel person;
                if (_person != null)
                {
                    person = _person;
                    person.FirstName = firstNameText.Text;
                    person.LastName = lastNameText.Text;
                    person.Addresses = addresses.ToList();
                    person.IsActive = isActiveCheck.IsChecked ?? false;
                }
                else 
                {
                    person = new PersonModel
                    {
                        FirstName = firstNameText.Text,
                        LastName = lastNameText.Text,
                        Addresses = addresses.ToList(),
                        IsActive = isActiveCheck.IsChecked ?? false
                    };
                }
                
                _parent.SavePerson(person);
                Close();
            }
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(firstNameText.Text) && !string.IsNullOrWhiteSpace(lastNameText.Text) 
                && addresses.ToList().Count > 0 && isActiveCheck.IsChecked != null;
        }

        private void addAddressButton_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry addressEntry = new AddressEntry(this);
            addressEntry.Show();
        }
    }
}
