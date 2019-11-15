using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroProject
{
    class Program
    {
        private static List<Hero> heroes = new List<Hero>();
        public static void LoadHeroesFromFile(string filename)
        {
            string[] data = File.ReadAllLines(filename);

            heroes.Add(new Hero("Vladimir", "Maardu"));
            heroes.Add(new SuperHero("Superman", "The Maardu"));
        }
        static void Main(string[] args)
        {
            Hero h1 = new Hero("Vadim", "Narva");
            Console.WriteLine(h1);
            Console.WriteLine(h1.rescue(100));
            SuperHero s1 = new SuperHero("Joe", "Nigeria");
            int inDanger = 1000;
            int rescued = h1.rescue(inDanger);
            Console.WriteLine(s1);
            Console.WriteLine(s1.rescue(100));
            rescued = s1.rescue(inDanger);
            Console.WriteLine(s1 + $" saved + {rescued}/{inDanger}");
        }
    }
}
