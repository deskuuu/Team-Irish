namespace BattleGame
{
    using System;
    using Contracts;
    using Engine;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            MusicPlayer backgroundMusicPlayer = new MusicPlayer(".\\Media\\music.wav");
            backgroundMusicPlayer.PlayLooping();
            IEngine engine = new GameEngine();
            engine.OnEngineMessageEvent += (message) => Console.WriteLine(message);
            engine.Start();
        }
    }
}
