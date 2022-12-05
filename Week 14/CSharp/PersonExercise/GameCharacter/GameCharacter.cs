using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
    internal class GameCharacter
    {
        private string name;
        private int health;

        public GameCharacter(string name)
        {
            Random rnd = new Random();
            Name = name;
            Health = rnd.Next(75, 100);
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Name {
            get { return name; }
            set { name = value; } 
        }

        public int Health { 
            get { return health; } 
            set { if (0 <= value && value <= 100)
                {
                    health = value;
                }
            } 
        }

        public void ReceivedDamage(int damage)
        {
            Health -= damage;
        }

        public string GetInfo()
        {
            return $"{Health}/100";
        }
    }
}
