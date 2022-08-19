using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns

{
    internal class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak_DuckCall");
        }
    }
}
