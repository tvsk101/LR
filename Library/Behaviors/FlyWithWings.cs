using System;
using Library.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Behaviors
{
    public class FlyWithWings : FlyBehavior
    {
        public string Fly()
        {
            return "Хлоп хлоп хлоп";
        }
    }
}
