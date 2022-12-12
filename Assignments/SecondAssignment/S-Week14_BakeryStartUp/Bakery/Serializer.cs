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
        public string bread;

        public Serializer(string name, string bread)
        {
            this.name = name;
            this.bread = bread;
        }

    }
}
