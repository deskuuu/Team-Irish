namespace BattleGame
{
    using Contracts;
    using Engine;

    public class Startup
    {
        public static void Main()
        {
            IEngine engine = GameEngine.Instance;
            engine.Start();
        }
    }
}
