using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class Ingredient
    {
        private string name;
        private double price;

        public Ingredient(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

    }
}
