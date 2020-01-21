using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public enum Gender
    {
        Male,
        Female,
        Undefined
    };

    public class Client
    {
        private string firstName;
        private string lastName;
        private Gender gender;
        private string notes;
        private List<Appointment> appointments;

        public Client()
        {
            appointments = new List<Appointment>();
        }

        public Client(string firstName, string lastName, Gender gender, string notes)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.notes = notes;
            appointments = new List<Appointment>();
        }

        public string FullName
        {
            get => firstName + " " + lastName;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Notes { get => notes; set => notes = value; }

        public List<Appointment> Appointments { get => appointments; set => appointments = value; }
        public Gender Gender { get => gender; set => gender = value; }
    }
}
