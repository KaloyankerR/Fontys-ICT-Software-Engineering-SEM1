using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int YearProduced { get; set; }
        
        public double Price { get; set; }

        public Car(string brand, string model, int yearProduced, double price)
        {
            Brand = brand;
            Model = model;
            YearProduced = yearProduced;
            Price = price;
        }

        public string GetInfo()
        {
            return $"{Brand} {Model} - produced in {YearProduced} - {Price}$";
        }

    }
}
