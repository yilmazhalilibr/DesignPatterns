using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public class MusicPlayer
    {
        IMusicState musicState;
        IMusicState musicPlay;
        IMusicState musicStop;

        public MusicPlayer()
        {
            musicPlay = new MusicPlay(this);
            musicStop = new MusicStop(this);
            musicState = musicPlay;
        }
        public void SetPlay() => musicState = musicPlay;
        public void SetStop() => musicState = musicStop;
        public void Play() => musicState.PlayMusic();
        public void Stop() => musicState.StopMusic();


    }
}
