using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    internal class Bakery
    {
        private int VAT_PERCENTAGE = 9;
        private string name;
        public List<string> sandwiches;

        public Bakery(string name)
        {
            this.name = name;
            sandwiches = new List<string>();
        }

        public string GetName()
        {
            return name;
        }

        public void AddSandwich(string sandwich) // Add sandwich in the construccto
        {
            if (sandwich == null)
            {
                MessageBox.Show("Null");
            } else
            {
                sandwiches.Add(sandwich);
            }
            
        }

        public List<string> GetSandwiches()
        {
            return sandwiches;
        }

    }
}
