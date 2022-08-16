using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesignPattern
{
    public class Tea : Beverage
    {
        public Tea()
        {
            _description = "Black Tea";
        }
        public override string GetDescription()
        {
            return _description;
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
