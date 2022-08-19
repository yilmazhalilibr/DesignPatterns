using DesignPatterns.IteratorDesignPattern.IteratorPart2;
using System;
using System.Collections;
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
            AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", true, 3.29);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);

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
        public IEnumerator CreateIterator()
        {
            IEnumerator enumerator = _menuItems.GetEnumerator();
            return enumerator;
        }
    }
}
