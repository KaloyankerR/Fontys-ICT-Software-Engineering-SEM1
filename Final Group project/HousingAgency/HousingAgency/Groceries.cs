using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingAgency
{
    internal class Grocery
    {
        private string name;
        private double cost;

        public Grocery(string productName, double productCost)        {
            this.name = productName;
            this.cost = productCost;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetCost()
        {
            return this.cost;
        }

    }
}
