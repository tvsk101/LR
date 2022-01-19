using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    public class RedheadDuck : Duck
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
    }
}
