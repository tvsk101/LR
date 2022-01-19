using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck RD1 = new RedheadDuck();
            MallardDuck MD1 = new MallardDuck();

            Duck[] Ducks = new Duck[] { MD1, RD1 };

            for (int i = 0; i < Ducks.Length; i++)
            {
                Console.WriteLine(Ducks[i].display());
                Console.WriteLine(Ducks[i].quack());
                Console.WriteLine(Ducks[i].swim());
            }
            Console.ReadKey();
        }
    }
}
