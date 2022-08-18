using DesignPatterns.IteratorDesignPattern.IteratorPart2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PrintMenu
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;
        List<object> breakFastItems;
        MenuItem[] lunchItems;
        public PrintMenu()
        {
            pancakeHouseMenu = new PancakeHouseMenu();
            dinerMenu = new DinerMenu();
            breakFastItems = pancakeHouseMenu.GetMenuList();
            lunchItems = dinerMenu.GetMenuItems();
        }
        public void GetBreakFastItems()
        {
            for (int i = 0; i < breakFastItems.Count; i++)
            {
                MenuItem menuItem = (MenuItem)breakFastItems[i];
                Console.WriteLine($"{menuItem.GetName()} \nPrice: {menuItem.GetPrice()} \nDescription: {menuItem.GetDescription()}");
                Console.WriteLine();
            }
        }
        public void GetLunchItems()
        {
            for (int i = 0; i < lunchItems.Length; i++)
            {
                MenuItem menuItem = lunchItems[i];
                Console.WriteLine($"{menuItem.GetName()} \nPrice: {menuItem.GetPrice()} \nDescription: {menuItem.GetDescription()}");
                Console.WriteLine();
            }
        }
    }
}
