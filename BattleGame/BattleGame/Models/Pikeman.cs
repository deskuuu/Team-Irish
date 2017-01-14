namespace BattleGame.Models
{
    using Common;
    using Common.Enums;
    using Units;

    public class Pikeman : ForceUnit
    {
        public Pikeman(string name) : base(name)
        {
            this.Attack = Constants.PikemanAttack;
            this.Defense = Constants.PikemanDefense;
            this.Health = Constants.PikemanHealth;
            this.AttackType = TypeOfAttack.LongRangeAttack;
        }

        public override string Print()
        {
            return base.Print();
        }
    }
}
