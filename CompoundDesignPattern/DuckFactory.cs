using DesignPatterns.CompoundDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();

        }

        public override IQuackable CreateRedheadDuck()
        {
            return new ReadheadDuck();

        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();

        }
    }
}
