using DesignPatterns.DecoratorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }
        public override string GetDescription()
        {
            return _description;
        }
        public override double Cost() => 1.99;
    }
}
