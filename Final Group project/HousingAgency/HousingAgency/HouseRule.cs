using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{
    internal class HouseRule
    {
        private string description;
        private int iD;

        public HouseRule(int id, string description)
        {
            this.iD = id;
            this.description = description;
        }

        public string GetInfo()
        { return $"ID {iD}: {description}"; }

    }
}
