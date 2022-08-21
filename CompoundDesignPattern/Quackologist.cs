using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Quackologist : IObserver1
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} just quacked.");
        }
    }
}
