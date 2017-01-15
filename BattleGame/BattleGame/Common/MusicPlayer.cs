using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Common
{
    class MusicPlayer
    {
        private SoundPlayer player;

        public SoundPlayer Player
        {
            get
            {
                return this.player;
            }
            private set
            {
                this.player = value;
            }
        }

        public MusicPlayer (string fileLocation)
        {
            this.Player = new SoundPlayer(fileLocation);
        }

        public void Play()
        {
            this.Player.Play();
        }
        public void PlayLooping()
        {
            this.Player.PlayLooping();
        }
    }
}
