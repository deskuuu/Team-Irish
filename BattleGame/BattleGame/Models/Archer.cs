namespace BattleGame.Models
{
    using Common;
    using Common.Enums;
    using Units;

    public class Archer : ForceUnit
    {
        public Archer(string name) : base(name)
        {
            this.Attack = Constants.ArcherAttack;
            this.Defense = Constants.ArcherDefense;
            this.Health = Constants.ArcherHealth;
            this.AttackType = TypeOfAttack.BrutalForce;
        }

        public override string Print()
        {
            return base.Print();
        }
    }
}
