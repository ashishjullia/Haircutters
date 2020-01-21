using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Project.Models;
namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataWrapper data;
        private DataWrapper temporaryData;

        internal DataWrapper Data 
        {
            get => data;
            set
            {
                data = value;
                SortDataGrid(dgFutureAppointments);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            data = Utilities.Utilities.ReadFromXML_Serialize();
            dgFutureAppointments.DataContext = data;
            cbServiceSearch.ItemsSource = data.Services;
            comboBoxColumnGender.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            SortDataGrid(dgFutureAppointments);
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = tbSearch.Text.ToLower();
            //First LINQ
            if (temporaryData == null)
            {
                performSearch(str, data);
            }
            else
            {
                performSearch(str, temporaryData);
            }
            
        }

        private void performSearch(string str, DataWrapper dataWrapper)
        {
            var query = dataWrapper.Clients.Where(x => x.FullName.ToLower().StartsWith(str));
            DataWrapper dw = new DataWrapper();
            dw.Clients = new List<Client>(query);
            dgFutureAppointments.DataContext = dw;
            SortDataGrid(dgFutureAppointments);
        }

        private void miNewAppointment_Click(object sender, RoutedEventArgs e)
        {
            NewAppointmentWindow newAppointmentWindow = new NewAppointmentWindow();
            newAppointmentWindow.Show();
        }

        private void miFileSave_Click(object sender, RoutedEventArgs e)
        {
            Utilities.Utilities.WriteToXML_Serialize(data);
        }

        private void miFileLoad_Click(object sender, RoutedEventArgs e)
        {
            data = Utilities.Utilities.ReadFromXML_Serialize();
            dgFutureAppointments.DataContext = data;
            SortDataGrid(dgFutureAppointments);
        }

        private void miFileClear_Click(object sender, RoutedEventArgs e)
        {
            Data.Clear();
            dgFutureAppointments.DataContext = null;
        }

        private void cbServiceSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Service service = (Service)cbServiceSearch.SelectedItem;
            if (service != null)
            {
                // Second LINQ
                var clients = from client in data.Clients
                              where client.Appointments.Any()
                              select client into subClient
                              from appointment in subClient.Appointments
                              where appointment.Service.ServiceName == service.ServiceName
                              select subClient;
                              
                DataWrapper dataWrapper = new DataWrapper();
                dataWrapper.Clients = new List<Client>(clients);
                dgFutureAppointments.DataContext = dataWrapper;
                SortDataGrid(dgFutureAppointments);
                temporaryData = dataWrapper;
                if(tbSearch.Text.Length != 0)
                {
                    performSearch(tbSearch.Text.ToLower(), temporaryData);
                }
            }
            else
            {
                temporaryData = null;
            }
        }

        private void btClearSelection_Click(object sender, RoutedEventArgs e)
        {
            cbServiceSearch.SelectedItem = null;
            dgFutureAppointments.DataContext = data;
            SortDataGrid(dgFutureAppointments);
            if (tbSearch.Text.Length != 0)
            {
                performSearch(tbSearch.Text.ToLower(), data);
            }
        }

        //The solution has taken from https://stackoverflow.com/questions/16956251/sort-a-wpf-datagrid-programmatically
        public void SortDataGrid(DataGrid dataGrid, int columnIndex = 0, ListSortDirection sortDirection = ListSortDirection.Descending)
        {
            var column = dataGrid.Columns[columnIndex];
            dataGrid.Items.SortDescriptions.Clear();
            dataGrid.Items.SortDescriptions.Add(new SortDescription(column.SortMemberPath, sortDirection));
            foreach (var col in dataGrid.Columns)
            {
                col.SortDirection = null;
            }
            column.SortDirection = sortDirection;
            dataGrid.Items.Refresh();
        }

        private void dgMenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Client)dgFutureAppointments.SelectedItem;
            data.Clients.Remove(selectedItem);
            dgFutureAppointments.DataContext = data;
            SortDataGrid(dgFutureAppointments);
        }
    }

    public class ColourFormatter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dateTime = (DateTime)value;
            if (dateTime > DateTime.Now) return Brushes.LightCoral;
            else return Brushes.LightBlue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}