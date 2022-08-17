using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDesignPattern.Garage
{
    public class GarageDoorOffCommand : ICommand
    {
        GarageDoor _door;
        public GarageDoorOffCommand(GarageDoor door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Down();
        }
    }
}
