using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MallardDuck : Duck, IQuackable
    {
        Observable1 _observable;
        public MallardDuck()
        {
            _observable = new Observable1(this);
        }
        public void RegisterObserver(IObserver1 observer)
        {
            _observable.RegisterObserver(observer);
        }
        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

      
     
        public override void Display()
        {
            Console.WriteLine("Mallard Duck : Display");
        }


        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }


    }
}
