namespace BattleGame.Factories
{
    using Contracts;
    using Models;

    public static class UnitFactory
    {
        public static IBattleUnit CreateArcher(string name)
        {
            return new Archer(name);
        }

        public static IBattleUnit CreateSwordman(string name)
        {
            return new Swordman(name);
        }

        public static IBattleUnit CreatePikeman(string name)
        {
            return new Pikeman(name);
        }

        public static IBattleUnit CreateMagician(string name)
        {
            return new Magician(name);
        }
    }
}
