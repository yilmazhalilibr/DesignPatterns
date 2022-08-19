using DesignPatterns.StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MusicStop : IMusicState
    {
        MusicPlayer _musicPlayer;
        public MusicStop(MusicPlayer musicPlayer)
        {
            _musicPlayer = musicPlayer;
        }
        public void PlayMusic()
        {
            _musicPlayer.SetPlay();
            Console.WriteLine("Music started.");

        }

        public void StopMusic()
        {
            Console.WriteLine("Music already stopped!");
        }
    }
}
