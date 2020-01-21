using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Service
    {
        private string serviceName;

        public Service()
        {
        }

        public Service(string serviceName)
        {
            this.serviceName = serviceName;
        }

        public string ServiceName { get => serviceName; set => serviceName = value; }

        public override bool Equals(object obj)
        {
            var service = obj as Service;
            if (service == null)
                return false;
            return service.ServiceName == ServiceName;
        }

        public override int GetHashCode() => new { ServiceName }.GetHashCode();
    }
}
