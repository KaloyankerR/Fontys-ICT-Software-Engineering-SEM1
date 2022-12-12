using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Member
    {
        private int studentNumber;
        private string name;

        public Member(string name)
        {
            this.name = name;
        }

        public Member(string name, int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
        }

        public string GetInfo()
        {
            if (studentNumber != null)
            {
                return $"{name} (nr, {studentNumber})";
            }
            else
            {
                return name;
            }

        }
    }
}

