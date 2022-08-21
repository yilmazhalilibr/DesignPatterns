using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns

{
    public class DuckCall : IQuackable
    {
        Observable1 _observable;
        public DuckCall()
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


        public void Quack()
        {
            Console.WriteLine("Kwak_DuckCall");
            NotifyObservers();
        }


    }
}
