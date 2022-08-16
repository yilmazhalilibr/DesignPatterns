using DesignPatterns.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ChicagoStylePizzaStore : PizzaStore
    {

        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            return null;
        }
    }
}
