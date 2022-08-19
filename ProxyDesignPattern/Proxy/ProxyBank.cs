using DesignPatterns.ProxyDesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class ProxyBank : IBank
    {
        Bank _bank;
        bool _login;
        string _user, _password;
        public ProxyBank(string user, string password)
        {
            _user = user;
            _password = password;
        }
        public bool Login()
        {
            if (_user.Equals("user") && _password.Equals("123"))
            {
                _bank = new Bank();
                _login = true;
                Console.WriteLine("Logic Success!");
                return true;
            }
            else
            {
                Console.WriteLine("Login Failed. Wrong pass or user");
                return false;
            }
        }


        public bool DoPay(double price)
        {
            Login();
            if (!_login)
            {
                Console.WriteLine("We can't get paid because the account is not logged in");
                return false;
            }
            else
            {
                _bank.DoPay(price);
                return true;
            }
        }






















    }
}
