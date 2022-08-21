using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Flock : IQuackable
    {
       Observable1 _observable;

        List<IQuackable> quackers = new List<IQuackable>();
        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
            _observable = new Observable1(this);

        }
        public void Quack()
        {
            IEnumerator<IQuackable> enumerator = quackers.GetEnumerator();

            while (enumerator.MoveNext() && enumerator.Current != null)
            {
                IQuackable quackable = enumerator.Current;
                quackable.Quack();
                NotifyObservers();

            }
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
