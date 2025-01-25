using DemoLibrary;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISavePerson
    {
        BindingList<PersonModel> people = new BindingList<PersonModel>();
        public MainWindow()
        {
            InitializeComponent();
            PeopleListBox.ItemsSource = people;
            var demoPerson = new PersonModel { FirstName = "Michael", LastName = "Scott", IsActive = true };
            demoPerson.Addresses.Add(new AddressModel { StreetAddress = "123 Scranton Dr", City = "Scranton", State = "PA", ZipCode = "12345" });
            people.Add(demoPerson);
        }

        public void SavePerson(PersonModel person)
        {
            people.Add(person);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PersonEntry personEntry = new PersonEntry(this);
            personEntry.Show();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var person = PeopleListBox.SelectedItem as PersonModel;
            if (person != null)
            {
                people.Remove(person); 
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var person = PeopleListBox.SelectedItem as PersonModel;
            if (person != null)
            {
                people.Remove(person);
                PersonEntry personEntry = new PersonEntry(this, person);
                personEntry.Show();
            }
        }
    }
}