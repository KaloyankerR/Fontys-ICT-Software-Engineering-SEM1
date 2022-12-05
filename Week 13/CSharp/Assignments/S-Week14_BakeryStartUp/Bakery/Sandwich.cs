using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class Sandwich
    {
        private string name;
        private double basePrice;
        private BreadType bread;
        private Ingredient[] ingredients;

        public Sandwich(string name, double basePrice, BreadType bread)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.bread = bread;
        }

        public string GetName()
        {
            return name;
        }

        public BreadType GetBread()
        {
            return bread;
        }

        public void AddIngredient(Ingredient i)
        {
            if (ingredients.Length < 5)
            {
                ingredients[ingredients.Length] = i;
            }
        }

        public string GetInfo()
        {
            string ingredientsString = string.Join("|", ingredients.Select(x => x.GetName()).ToArray());
            return $"{name} ({bread} with {string.Join(", ", ingredientsString)})";
        }

        public double GetPrice()
        {
            double ingredientsPrice = (ingredients.Select(x => x.GetPrice()).ToArray()).Sum();

            return basePrice + ingredientsPrice;
        }

    }
}
