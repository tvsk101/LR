using System;
using Library;
using Library.Behaviors;
using Library.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class RubberDuck : Duck
    {
        public override string Display()
        {
            return $"{GetType()} __ {flybehavior.GetType()} __ {quackbehavior.GetType()}";
        }
    }
}
