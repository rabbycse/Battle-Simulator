using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorBattle
{
    public class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter Warrior A name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please enter Warrior B name: ");
            string name2 = Console.ReadLine();


            Warrior w1 = new Warrior(name1, 1000, 120, 40);
            Warrior w2 = new Warrior(name2, 1000, 120, 40);

            Battle.StartFight(w1, w2);


            Console.ReadLine();
        }
    }
}


