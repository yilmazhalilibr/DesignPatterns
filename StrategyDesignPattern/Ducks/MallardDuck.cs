using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MallardDuck : Duck , IQuackable
    {

        public MallardDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Mallard Duck : Display");



        }

        public void Quack()
        {
            Console.WriteLine("Quack_Mallard");
        }
    }
}
