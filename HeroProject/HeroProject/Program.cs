using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Vadim", "Narva");
            Console.WriteLine($" saved {hero.rescue(100)}");
        }
    }
}
