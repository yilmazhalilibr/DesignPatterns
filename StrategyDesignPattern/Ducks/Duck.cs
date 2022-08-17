using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public Duck()
        { }

        public abstract void Display();

        public virtual void PerformFly()
        {
            flyBehavior.Fly();
        }
        public virtual void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

    }
}
