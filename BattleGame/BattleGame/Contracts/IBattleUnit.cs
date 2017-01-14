namespace BattleGame.Contracts
{
    public interface IBattleUnit : IUnit, IAttackingUnit
    {
        new int Attack { get; }

        new int Defense { get; }

        int Health { get; set; }
    }
}