using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public List<Car> CarsPuchased { get; set; }

        public Customer(int id, string firstName, string lastName, int phoneNumber, string email, string address, string zipcode, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Zipcode = zipcode;
            City = city;
            CarsPuchased = new List<Car>();
        }

        public Customer(int id, string firstName, string lastName, int phoneNumber, string address, string zipcode, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = "";
            Address = address;
            Zipcode = zipcode;
            City = city;
            CarsPuchased = new List<Car>();
        }
        

    }
}
