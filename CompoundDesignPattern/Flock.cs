using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();
        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void Quack()
        {
            IEnumerator<IQuackable> enumerator = quackers.GetEnumerator();

            while (enumerator.MoveNext() && enumerator.Current != null)
            {
                IQuackable quackable = enumerator.Current;
                quackable.Quack();

            }
        }




    }
}
