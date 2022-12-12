using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [Serializable]
    public class Serializer
    {
        public string name;
        public double price;

        public Serializer(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
