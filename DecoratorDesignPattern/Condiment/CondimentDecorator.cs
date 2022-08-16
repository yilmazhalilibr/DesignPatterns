using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesignPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();

        public override double Cost()
        {
            return 0;
        }
    }
}
