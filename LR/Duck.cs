﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    abstract class Duck
    {
        public string quack()
        {
            return "quack " + this.GetType();
        }
        public string swim()
        {
            return "swim " + this.GetType();
        }
        abstract public string display();
    }
}
