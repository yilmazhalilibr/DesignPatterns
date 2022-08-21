using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Observable1 : IQuackObservable
    {
        List<object> _observers = new List<object>();
        IQuackObservable _duck;

        public Observable1(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void NotifyObservers()
        {
            IEnumerator enumerator = _observers.GetEnumerator();
            while (enumerator.MoveNext() && enumerator.Current != null)
            {
                IObserver1 quackObservable = (IObserver1)enumerator.Current;
                quackObservable.Update(_duck);
            }
        }

        public void RegisterObserver(IObserver1 observer)
        {
            _observers.Add(observer);
        }
    }
}
