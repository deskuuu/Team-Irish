namespace BattleGame.Factories
{
    using Contracts;
    using Models;

    public static class PlayerFactory
    {
        public static IPlayer CreatePlayer()
        {
            return new Player();
        }
    }
}
