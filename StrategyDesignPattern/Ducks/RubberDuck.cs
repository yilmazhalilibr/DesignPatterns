using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RubberDuck : Duck
    {
       
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("Rubber Duck : Display");
        }



    }
}
