using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PersonelIterator : IIterator
    {
        PersonelAggregate _aggregate;
        int currentIndex;
        public PersonelIterator(PersonelAggregate personelAggregate) => _aggregate = personelAggregate;
        public Personel CurrentItem() => _aggregate.GetItem(currentIndex);
        public bool HasItem()
        {
            if (currentIndex < _aggregate.Count)
            {
                return true;
            }
            return false;
        }
        public Personel NextItem()
        {
            if (HasItem())
            {
                return _aggregate.GetItem(currentIndex++);
            }
            return new Personel();
        }
    }

}
