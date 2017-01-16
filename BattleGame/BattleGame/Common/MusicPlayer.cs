namespace BattleGame.Common
{
    using System.Media;

    public class MusicPlayer
    {
        private SoundPlayer player;

        public MusicPlayer(string fileLocation)
        {
            this.Player = new SoundPlayer(fileLocation);
        }

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
