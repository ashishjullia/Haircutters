using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project.Models
{
    [XmlRoot("Data")]
    public class DataWrapper
    {
        private List<Client> clients;
        private ObservableCollection<Service> services;
        public DataWrapper()
        {
            Clients = new List<Client>();
            services = new ObservableCollection<Service>();
        }

        public List<Client> Clients { get => clients; set => clients = value; }
        public ObservableCollection<Service> Services { get => services; set => services = value; }

        public void Clear()
        {
            clients.Clear();
        }
    }
}
