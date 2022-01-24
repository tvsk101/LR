using System;
using Library;
using Library.Behaviors;
using Library.Interfaces;
using Library.Entities;
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

            FlyBehavior flynoway = new FlyNoWay();
            FlyBehavior flywithwings= new FlyWithWings();

            QuackBehavior mutequack = new MuteQuack();
            QuackBehavior dquack = new DQuack();
            QuackBehavior squeak = new Squeak();

            RD.SetFlyBehavior(flywithwings);
            RD.SetQuackBehavior(dquack);

            MD.SetFlyBehavior(flywithwings);
            MD.SetQuackBehavior(dquack);

            DD.SetFlyBehavior(flynoway);
            DD.SetQuackBehavior(mutequack);

            RubD.SetFlyBehavior(flynoway);
            RubD.SetQuackBehavior(squeak);

            Duck[] Ducks = new Duck[] { MD, RD, DD, RubD};

            foreach (Duck duck in Ducks)
            {
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.PerformFly());
                Console.WriteLine(duck.PerformQuack());


            }
            Console.ReadKey();
        }
    }
}
