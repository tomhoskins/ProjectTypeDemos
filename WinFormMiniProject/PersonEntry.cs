using DemoLibrary;
using System.ComponentModel;

namespace WinFormMiniProjectTim
{
    public partial class PersonEntryForm : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonEntryForm()
        {
            InitializeComponent();
            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddressModel newAddress = new AddressModel();

            // Open the address entry form
            AddressEntry entry = new AddressEntry(this);
            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList()
            };
        }
    }
}
