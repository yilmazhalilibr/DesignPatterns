using DesignPatterns.ProxyDesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Bank : IBank
    {
        public bool DoPay(double price)
        {
            if (price >= 100)
            {
                Console.WriteLine("Pay Succes!");
                return true;
            }
            else
            {   
                Console.WriteLine("Cannot be paid less than $100.");
                return false;
            }
        }
    }
}
