using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class QuackCounter : IQuackable
    {
        IQuackable _duck;
        static int _numberOfQuacks;
        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
        }
        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }
    }
}
