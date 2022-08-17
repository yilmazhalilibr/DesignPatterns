using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TurkeyAdapter : Duck
    {
        ITurkey _turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public override void PerformQuack()
        {
            _turkey.PerformQuack();
        }
        public override void PerformFly()
        {
            for (int i = 0; i < 2; i++)
            {
                _turkey.PerformFly();
            }
        }
        public override void Display()
        {
            Console.WriteLine("I'm turkey : Display Method");
        }
    }
}
