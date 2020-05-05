using ContactsSQLite.Tools;
using System;
using System.Windows;
using SQLite;

namespace ContactsSQLite
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhoneNumber.Text
            };

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            }

            this.Close();
        }
    }
}
