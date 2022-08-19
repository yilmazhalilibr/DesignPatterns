using DesignPatterns.StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MusicPlay : IMusicState
    {
        MusicPlayer _musicPlayer;
        public MusicPlay(MusicPlayer musicPlayer)
        {
            _musicPlayer = musicPlayer;
        }
        public void PlayMusic()
        {
            Console.WriteLine("Music already working.");
        }

        public void StopMusic()
        {
            Console.WriteLine("Music Stopped!");
            _musicPlayer.SetStop();
        }
    }
}
