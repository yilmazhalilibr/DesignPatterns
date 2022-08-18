using DesignPatterns.IteratorDesignPattern.IteratorPart2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] _items;
        int _position;
        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }
        public bool HashNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
