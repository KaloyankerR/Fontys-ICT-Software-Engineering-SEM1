using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{
    internal class Announcement
    {
        private string title;
        private string description;
        DateTime date = DateTime.Now;
        
        public Announcement(string description)
        {
            this.title = "";
            this.description = description;
        }
        public Announcement(string title, string description)
        {
            this.title = title;
            this.description = description;
        }   

        public string GetTitle()
        {
            return title;
        }

        public string GetDiscription()
        {
            return description;
        }
        public string GetDate()
        {
            return date.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
