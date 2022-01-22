using System;
using Library.Behaviors;
using Library.Interfaces;
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
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.Swim());

                if (duck is QuackBehavior)
                {
                    Console.WriteLine((duck as QuackBehavior).Quack());
                }

                if (duck is FlyBehavior)
                {
                    Console.WriteLine((duck as FlyBehavior).Fly());
                }

            }
            Console.ReadKey();
        }
    }
}
