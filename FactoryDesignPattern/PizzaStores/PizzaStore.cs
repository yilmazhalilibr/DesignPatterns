using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public abstract class PizzaStore
    {
        protected PizzaStore _factory;

        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type, PizzaStore _factory)
        {
            Pizza pizza;

            pizza = _factory.CreatePizza(type); ;

            pizza.Prepare(type);
            pizza.Bake(type);
            pizza.Cut(type);
            pizza.Box(type);

            return pizza;


        }

    }

}
