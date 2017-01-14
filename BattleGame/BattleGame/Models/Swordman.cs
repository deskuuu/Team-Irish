namespace BattleGame.Models
{
    using Common;
    using Common.Enums;
    using Contracts;
    using Units;

    public class Swordman : ForceUnit, IBattleUnit
    {
        public Swordman(string name) : base(name)
        {
            this.Attack = Constants.SwordmanAttack;
            this.Defense = Constants.SwordmanDefense;
            this.Health = Constants.SwordmanHealth;
            this.AttackType = TypeOfAttack.MiddleRangeAttack;
        }

        public override string Print()
        {
            return base.Print();
        }
    }
}