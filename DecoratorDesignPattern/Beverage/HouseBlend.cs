using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesignPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() 
        {
            _description = "House Blend";
        }
        public override  string GetDescription()
        {
            return _description;
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
