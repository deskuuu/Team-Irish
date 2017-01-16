namespace BattleGame.Contracts
{
    using Common.Enums;

    public interface IAttackingUnit
    {
        TypeOfAttack AttackType { get; set; }
    }
}
