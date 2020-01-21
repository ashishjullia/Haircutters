using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Project.Models;

namespace Project
{
    /// <summary>
    /// Interaction logic for NewAppointmentWindow.xaml
    /// </summary>
    public partial class NewAppointmentWindow : Window
    {
        private DataWrapper data;
        public NewAppointmentWindow()
        {
            InitializeComponent();
            data = ((MainWindow)Application.Current.MainWindow).Data;
            cbGender.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            cbService.ItemsSource = data.Services;
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            if(Validation())
            {
                string firstName = tbFirstName.Text.ToLower();
                string lastName = tbLastName.Text.ToLower();
                firstName = uppercaseFirst(firstName);
                lastName = uppercaseFirst(lastName);
                string notes = tbNotes.Text;
                string address = tbAddress.Text;
                Gender gender = (Gender)cbGender.SelectedItem;
                DateTime dateTime = dateTimePicker.Value.Value;
                Service service = (Service)cbService.SelectedItem;
                
                Appointment appointment = new Appointment();
                if(cbSalon.IsChecked.Value)
                {
                    appointment = new Appointment(dateTime, service);
                }
                else
                {
                    appointment = new Appointment(dateTime, service, address);
                }

                Client client = new Client();
                client = new Client(firstName, lastName, gender, notes);
                data.Clients.Add(client);
                client.Appointments.Add(appointment);
                ((MainWindow)Application.Current.MainWindow).Data = data;
                ((MainWindow)Application.Current.MainWindow).dgFutureAppointments.DataContext = data;
                Close();
            }
        }

        private bool Validation()
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string notes = tbNotes.Text;
            string address = tbAddress.Text;
            if (firstName.Length == 0 || lastName.Length == 0)
            {
                MessageBox.Show("You have to fill out all fields");
                return false;
            }
            if(cbGender.SelectedItem == null)
            {
                MessageBox.Show("You have to select gender");
                return false;
            }
            if (cbService.SelectedItem == null)
            {
                MessageBox.Show("You have to select service type");
                return false;
            }
            if (!cbSalon.IsChecked.Value && address.Length == 0)
            {
                MessageBox.Show("You have to enter the address");
                return false;
            }
            if(dateTimePicker.Value == null)
            {
                MessageBox.Show("You have to pick up date and time");
                return false;
            }

            if (Regex.IsMatch(firstName, @"\d"))
            {
                MessageBox.Show("First name field should only contain letters");
                return false;
            }

            if (Regex.IsMatch(lastName, @"\d"))
            {
                MessageBox.Show("Last name field should only contain letters");
                return false;
            }

            return true;
        }

        private void cbSalon_Checked(object sender, RoutedEventArgs e)
        {
            labelAddress.Visibility = Visibility.Hidden;
            tbAddress.Visibility = Visibility.Hidden;
        }

        private void cbSalon_Unchecked(object sender, RoutedEventArgs e)
        {
            labelAddress.Visibility = Visibility.Visible;
            tbAddress.Visibility = Visibility.Visible;
        }

        private string uppercaseFirst(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
