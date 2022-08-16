
using DesignPatterns.FactoryDesignPattern;
using System;
using System.Linq;

namespace DesignPatterns
{
    public class NYStylePizzaStore : PizzaStore
    {


        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            return null;
        }
    }
}
