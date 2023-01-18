using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{

    internal class ComplaintModel
    {
        string level, title, description;

        public ComplaintModel(string level, string title, string description)
        {
            Update(level, title, description);
        }

        private void ValidateLevel(string level)
        {
            switch (level)
            {
                case "Low":
                case "Medium":
                case "High":
                    break;
                default:
                    throw new InvalidOperationException("Invalid complaint level");
            }
        }

        public void Update(string level, string title, string description)
        {
            ValidateLevel(level);
            this.title = title;
            this.description = description;
            this.level = level;
        }

        public string GetLevel()
        { return this.level; }

        public string GetTitle()
        { return this.title; }

        public string Getdescription()
        { return this.description; }



    }
}
