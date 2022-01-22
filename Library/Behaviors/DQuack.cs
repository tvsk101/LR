using System;
using Library.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Behaviors
{
    public class DQuack : QuackBehavior
    {
        public string Quack()
        {
            return "Кря кря кря";
        }
    }
}
