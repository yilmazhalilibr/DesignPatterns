using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RubberDuck : Duck, IQuackable
    {
        Observable1 _observable;

        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
            _observable = new Observable1(this);

        }
        public override void Display()
        {
            Console.WriteLine("Rubber Duck : Display");
        }


        public void Quack()
        {
            Console.WriteLine("Squeak_Rubber");
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
