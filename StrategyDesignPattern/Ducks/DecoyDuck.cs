using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DecoyDuck : Duck
    {

        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();


        }

        public override void Display()
        {
            Console.WriteLine("Display Method : Decoy Duck!");
        }


    }
}
