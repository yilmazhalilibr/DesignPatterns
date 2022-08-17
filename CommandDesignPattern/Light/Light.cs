using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDesignPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light Open");
        }
        public void Off()
        {
            Console.WriteLine("Light Off");
        }
    }
}
