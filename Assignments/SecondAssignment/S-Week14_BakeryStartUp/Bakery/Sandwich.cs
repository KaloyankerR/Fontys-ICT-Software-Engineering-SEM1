using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [Serializable]
    public class Sandwich
    {
        private string name;
        private double basePrice;
        // private BreadType bread;
        private string bread;
        private Ingredient[] ingredients;

        public Sandwich(string name, double basePrice, string bread)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.bread = bread;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        public string Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        public string GetName()
        {
            return name;
        }

        public string GetBread()
        {
            return bread;
        }

        //public void AddIngredient(Ingredient i)
        //{
        //    if (ingredients.Length < 5)
        //    {
        //        ingredients[ingredients.Length] = i;
        //    }
        //}

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
