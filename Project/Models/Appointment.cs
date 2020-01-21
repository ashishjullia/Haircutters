using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Project.Models
{
    public class Appointment
    {
        private DateTime dateTime;
        private Service service;
        private string address = "Salon`s address";
        private Client client;

        public Appointment()
        {
        }

        public Appointment(DateTime dateTime, Service service, string address)
        {
            this.dateTime = dateTime;
            this.service = service;
            this.address = address;
        }

        public Appointment(DateTime dateTime, Service service)
        {
            this.dateTime = dateTime;
            this.service = service;
        }

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Address { get => address; set => address = value; }
        public Service Service { get => service; set => service = value; }
        public Client Client { get => client; set => client = value; }
    }

    
}
