using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesignPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Most Excellent Dark Roast ";
        }
        public override string GetDescription() 
        {
            return _description;
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
