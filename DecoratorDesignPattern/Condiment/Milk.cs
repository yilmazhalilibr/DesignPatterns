﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesignPattern.Condiment
{
    public class Milk : CondimentDecorator
    {
        Beverage _beverage;
        public Milk(Beverage beverage)
        {
            _beverage = beverage;

        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Milk";

        }
        public override double Cost() => _beverage.Cost() + 0.33;
    }
}
