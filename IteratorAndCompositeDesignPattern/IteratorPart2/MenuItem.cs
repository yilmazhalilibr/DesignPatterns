using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MenuItem
    {
        protected string _name;
        protected string _description;
        protected bool _vegeterian;
        protected double _price;



        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            _name = name;
            _description = description;
            _vegeterian = vegeterian;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public bool GetIsVegeterian()
        {
            return _vegeterian;
        }
        public double GetPrice()
        {
            return _price;
        }






    }
}
