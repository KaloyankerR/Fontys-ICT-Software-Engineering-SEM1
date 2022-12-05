using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string gender;
        private int birthYear;

        public string FirstName { 
            get { return firstName;  }
            set { firstName = value; } 
        }

        public string LastName {
            get { return lastName; }
            set { lastName = value;  } 
        }
        public string Gender {
            get { return gender;  }
            set { gender = value; }
        }

        public int BirthYear { 
            get { return birthYear; }
            set {
                if (value > 0)
                {
                    birthYear = value;
                }
                else
                {
                    birthYear = 2000;
                }                
            }
        }

        public string GetInfo()
        {
            return $"{firstName} {lastName} - {gender} - {birthYear}";
        }
    }
}
