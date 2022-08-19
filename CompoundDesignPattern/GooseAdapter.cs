using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompoundDesignPattern
{
    internal class GooseAdapter : IQuackable
    {
        Goose _goose;
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }
        public void Quack()
        {
            _goose.Honk();
        }
    }
}
