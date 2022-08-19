using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyDesignPattern.Proxy
{
    internal interface IBank
    {
        bool DoPay(double price);
    }
}
