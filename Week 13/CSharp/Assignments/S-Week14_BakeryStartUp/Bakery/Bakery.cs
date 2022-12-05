using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class Bakery
    {
        private int VAT_PERCENTAGE = 9;
        private string name;

        public Bakery(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void AddSandwich() // Add sandwich in the construccto
        {
            // pass
        }
    }
}
