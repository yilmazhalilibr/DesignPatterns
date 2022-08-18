using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorDesignPattern.IteratorPart2
{
    public interface Iterator
    {
        bool HashNext();
        object Next();
    }
}
