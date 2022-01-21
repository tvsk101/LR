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

                if (duck is IQuackableInterface)
                {
                    Console.WriteLine((duck as IQuackableInterface).quack());
                }

                if (duck is IFlyableInterface)
                {
                    Console.WriteLine((duck as IFlyableInterface).fly());
                }

            }
            Console.ReadKey();
        }
    }
}
