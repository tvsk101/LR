using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    public class RubberDuck : Duck , IQuackable
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
        public string quack()
        {
            return "quack " + this.GetType();
        }
    }
}
