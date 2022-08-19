using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public interface IMusicState
    {
        void PlayMusic();
        void StopMusic();
    }
}
