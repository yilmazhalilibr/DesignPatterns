using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorDesignPattern
{
    public abstract class Beverage
    {
        public string _description = "Unknown Beverage";



        public abstract string GetDescription();


        public abstract double Cost();

    }
}
