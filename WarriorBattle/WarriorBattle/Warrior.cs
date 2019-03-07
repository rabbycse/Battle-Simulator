using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorBattle
{
    public class Warrior
    {
        // Warrior properties
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Generating random numbers
        Random rnd = new Random();

        // Constructor creation
        public Warrior(string name = "Warrior", double health = 0, double attkmax = 0, double blockmax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkmax;
            BlockMax = blockmax;
        }

        // Generate random attack value for warrior
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // Generate random block value for warrior
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }


    }
}
