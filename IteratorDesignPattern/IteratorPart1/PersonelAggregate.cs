using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PersonelAggregate
    {
        List<Personel> PersonelList = new List<Personel>();
        public void Add(Personel Model) => PersonelList.Add(Model);
        public Personel GetItem(int index) => PersonelList[index];
        public int Count { get => PersonelList.Count; }
        public IIterator CreateIterator() => new PersonelIterator(this);
    }
}
