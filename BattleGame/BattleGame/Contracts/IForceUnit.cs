namespace BattleGame.Contracts
{
    using Common.Enums;

    public interface IForceUnit : IUnit
    {
        TypeOfAttack AttackType { get; }
    }
}
