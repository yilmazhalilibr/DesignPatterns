using DesignPatterns.IteratorDesignPattern.IteratorPart2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DinerMenu
    {
        static readonly int MAX_ITEMS = 6;
        internal int _numberOfItems = 0;
        internal MenuItem[] _menuItems;


        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can’t add item to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }
        /*
        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }*/
        public IteratorDesignPattern.IteratorPart2.IIterator CreateIterator() 
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
