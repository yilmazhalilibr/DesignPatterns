using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IIterator
    {
        bool HasItem();
        Personel NextItem();
        Personel CurrentItem();
    }
}
