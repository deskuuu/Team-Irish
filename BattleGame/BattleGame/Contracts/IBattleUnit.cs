namespace BattleGame.Contracts
{
    public interface IBattleUnit : IUnit
    {
        new int Attack { get; }

        new int Defense { get; }

        int Health { get; set; }
    }
}