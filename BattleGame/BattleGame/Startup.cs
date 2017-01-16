namespace BattleGame
{
    using System;

    using Common;
    using Contracts;
    using Engine;

    public class Startup
    {
        public static void Main()
        {
            var backgroundMusicPlayer = new MusicPlayer(Constants.MusicPath);
            backgroundMusicPlayer.PlayLooping();
            IEngine engine = new GameEngine();
            engine.OnEngineMessageEvent += (message) => Console.WriteLine(message);
            engine.Start();
        }
    }
}
