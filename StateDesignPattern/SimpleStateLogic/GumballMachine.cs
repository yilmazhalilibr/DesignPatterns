using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class GumballMachine
    {
        static readonly int SOLD_OUT = 0;
        static readonly int NO_QUARTER = 1;
        static readonly int HAS_QUARTER = 2;
        static readonly int SOLD = 3;

        int _state = SOLD_OUT;
        int _count = 0;




        
        public GumballMachine(int count)
        {
            _count = count;
            if (_count>0)
            {
                _state = NO_QUARTER;
            }
        }
        public void InsertQuarter() 
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("You can’t insert another quarter");
            }
            else if (_state == NO_QUARTER)
            {
                _state = NO_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (_state==SOLD_OUT)
            {
                Console.WriteLine("You can’t insert a quarter, the machine is sold out");
            }
            else if (_state == SOLD)
            {
                Console.WriteLine("Please wait, we’re already giving you a gumball");
            }
        }
        public void EjectQuarter() 
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
            }
            else if (_state == NO_QUARTER)
            {
                _state = NO_QUARTER;
                Console.WriteLine("You haven’t inserted a quarter");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (_state == SOLD)
            {
                Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
            }
        }
        public void TurnCrank()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("Turning twice doesn’t get you another gumball");
            }
            else if (_state == NO_QUARTER)
            {
                Console.WriteLine("You turned but there’s no quarter");

            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (_state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                _state = SOLD;
                Dispense();
            }
        }
        public void Dispense()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                _count = _count - 1;
                if (_count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _state = SOLD_OUT;
                }
                else
                {
                    _state = NO_QUARTER;
                }
            }
            else if (_state == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (_state == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (_state == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }
        



    }
}
