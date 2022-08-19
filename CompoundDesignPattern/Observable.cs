using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class QuackObservable : IQuackObservable
    {
        List<object> _observers = new List<object>();
        QuackObservable _duck;
        public QuackObservable(QuackObservable duck)
        {
            _duck = duck;
        }
        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver(IObserverCompound observer)
        {
            IEnumerator<object> enumerator = _observers.GetEnumerator();
            while (enumerator.MoveNext() && enumerator.Current != null)
            {
                IObserverCompound _observers = (IObserverCompound)enumerator.Current;
                _observers.Update(_duck);
            }
        }
    }
}
