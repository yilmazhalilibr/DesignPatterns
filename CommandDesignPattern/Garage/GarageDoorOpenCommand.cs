using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDesignPattern.Garage
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor _door;
        public GarageDoorOpenCommand(GarageDoor door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Up();
        }
    }
}
