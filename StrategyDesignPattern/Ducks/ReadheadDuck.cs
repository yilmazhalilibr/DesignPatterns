using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ReadheadDuck : Duck ,IQuackable
    {
      
        public ReadheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Readhead Duck : Display");


        }

        public void Quack()
        {
            Console.WriteLine("Quack_Readhead");
        }
    }
}
