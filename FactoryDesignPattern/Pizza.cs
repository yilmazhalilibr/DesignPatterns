using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class Pizza
    {




        public void Prepare(string name)
        {
            Console.WriteLine(name + " Prepare");
        }
        public void Bake(string name)
        {
            Console.WriteLine(name + " Pizza Bake");

        }
        public void Cut(string name)
        {
            Console.WriteLine(name + " Pizza Cut");

        }
        public void Box(string name)
        {
            Console.WriteLine(name + " Pizza Box");

        }

    }
}
