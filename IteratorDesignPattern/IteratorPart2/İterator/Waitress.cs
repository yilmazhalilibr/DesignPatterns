using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorDesignPattern.IteratorPart2.İterator
{
    public class Waitress
    {
        PancakeHouseMenu _pancakeHouseMenu;
        DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu , DinerMenu dinerMenu) 
        {
            _dinerMenu = dinerMenu;
            _pancakeHouseMenu = pancakeHouseMenu;

        }

        public void PrintMenu() 
        {
            IIterator pancakeIterator = _pancakeHouseMenu.Create
        }




    }
}
