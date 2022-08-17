using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WildTurkey : ITurkey
    {
        public WildTurkey() 
        {

        }
        public  void PerformFly()
        {
            
            Console.WriteLine("I’m flying a short distance");
        }

        public void PerformQuack()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
