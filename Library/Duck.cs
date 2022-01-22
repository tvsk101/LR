using System;
using Library.Interfaces;
using Library.Behaviors;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Duck 
    {
        protected FlyBehavior flybehavior;
        protected QuackBehavior quackbehavior;

        public string Swim()
        {
            return "Буль буль буль";
        }
        public abstract string Display();

        public string PerformFly()
        {
            return flybehavior.Fly();
        }

        public string PerformQuack()
        {
            return quackbehavior.Quack();
        }

        public void SetFlyBehavior(FlyBehavior flyb)
        {
            flybehavior = flyb;
        }
        public void SetQuackBehavior(QuackBehavior quackb)
        {
            quackbehavior = quackb;
        }
    }
}
