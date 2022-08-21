using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ReadheadDuck : Duck, IQuackable
    {
        Observable1 _observable;

        public ReadheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
            _observable = new Observable1(this);

        }
        public override void Display()
        {
            Console.WriteLine("Readhead Duck : Display");
        }
        public void Quack()
        {
            Console.WriteLine("Quack_Readhead");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
        public void RegisterObserver(IObserver1 observer)
        {
            _observable.RegisterObserver(observer);
        }
    }
}
