using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{
    internal class User
    {
        private string name;
        private string password;
        private bool isAdmin;

        public User(string name, string password, bool isAdmin)
        {
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public bool isValid()
        {
            return isAdmin;
        }
    }
}
