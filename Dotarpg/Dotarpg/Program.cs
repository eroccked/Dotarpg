using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotarpg
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrenghtHero s1 = new StrenghtHero(100, 100, 100);
            StrenghtHero s1 = new StrenghtHero();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.strenght);
            Console.WriteLine(s1.agility);
            Console.WriteLine(s1.intelligence);
            Console.ReadKey();
        }
    }
}
