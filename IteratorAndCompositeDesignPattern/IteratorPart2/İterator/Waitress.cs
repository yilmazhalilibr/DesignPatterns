using DesignPatterns.IteratorDesignPattern.IteratorPart2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Waitress
    {
        PancakeHouseMenu _pancakeHouseMenu;
        DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _dinerMenu = dinerMenu;
            _pancakeHouseMenu = pancakeHouseMenu;
        }

        public void PrintMenu()
        {
            IEnumerator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IEnumerator dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);

        }

        public void PrintMenu(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                if (enumerator.Current == null)
                {
                    break;
                }
                MenuItem menuItem = (MenuItem)enumerator.Current;
                Console.WriteLine($"Food :{menuItem.GetName()}\nPrice :{menuItem.GetPrice()}\nDescription: {menuItem.GetDescription()}");

            }
        }





    }
}
