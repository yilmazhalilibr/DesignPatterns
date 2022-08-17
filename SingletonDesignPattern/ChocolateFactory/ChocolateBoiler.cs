using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonDesignPattern.ChocolateFactory
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private volatile static ChocolateBoiler _instance = new ChocolateBoiler();

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }
        //[MethodImpl(MethodImplOptions.Synchronized)]
        public static ChocolateBoiler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChocolateBoiler();
                }
                return _instance;
            }

        }
        public void Fill()
        {
            if (isEmpty())
            {
                Console.WriteLine("Boiler is filled!");
                _empty = false;
                _boiled = false;
            }
        }
        public void Drain()
        {
            if (!isEmpty() && isBoiled())
            {
                Console.WriteLine("Boiler is drained!");
                _empty = true;
            }
        }
        public void Boil()
        {
            if (isEmpty().Equals(false) && isBoiled().Equals(false))
            {
                Console.WriteLine("Boiler is boiled!");
                _boiled = true;

            }
        }
        public bool isEmpty()
        {
            Console.WriteLine("Boiler is " + _empty);
            return _empty;
        }
        public bool isBoiled()
        {
            Console.WriteLine("Boiler is " + _boiled);
            return _boiled;
        }

    }
}
