namespace BattleGame.Models
{
    using Common;
    using Common.Enums;
    using Units;

    public class Magician : MagicUnit
    {
        public Magician(string name) : base(name)
        {
            this.Attack = Constants.MagicianAttack;
            this.Defense = Constants.MagicianDefense;
            this.Health = Constants.MagicianHealth;
            this.AttackType = TypeOfAttack.Magic;
        }

        public override string Print()
        {
            return base.Print();
        }
    }
}
