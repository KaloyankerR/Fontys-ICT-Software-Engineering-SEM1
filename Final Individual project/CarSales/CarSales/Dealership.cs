using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Dealership
    {
        private string name;
        private List<Car> cars;

        public Dealership(string name)
        {
            this.name = name;
            this.cars = new List<Car>();
        }
    }
}
