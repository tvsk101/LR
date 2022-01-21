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
            RedheadDuck RD = new RedheadDuck();
            MallardDuck MD = new MallardDuck();
            DecoyDuck DD = new DecoyDuck();
            RubberDuck RubD = new RubberDuck();

            Duck[] Ducks = new Duck[] { MD, RD, DD, RubD};

            foreach (Duck duck in Ducks)
            {
                Console.WriteLine(duck.display());
                Console.WriteLine(duck.swim());

                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).quack());
                }

                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).fly());
                }

            }
            Console.ReadKey();
        }
    }
}
