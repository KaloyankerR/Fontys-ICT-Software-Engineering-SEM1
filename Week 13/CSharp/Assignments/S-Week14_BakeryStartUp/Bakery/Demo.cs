using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Demo
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Bread { get; set; }
        public string GetInfo()
        {
            return $"{Name} - {Price} - {Bread}";
        }
    }
}
