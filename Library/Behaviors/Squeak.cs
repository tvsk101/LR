using System;
using Library.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Behaviors
{
    public class Squeak : QuackBehavior
    {
        public string Quack()
        {
            return "Пи пи пи";
        }
    }
}
