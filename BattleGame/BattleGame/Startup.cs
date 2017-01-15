namespace BattleGame
{
    using System;
    using Contracts;
    using Engine;

    public class Startup
    {
        public static void Main()
        {
            IEngine engine = new GameEngine();
            engine.OnEngineMessageEvent += (message) => Console.WriteLine(message);
            engine.Start();
        }
    }
}
