namespace BattleGame.Models.Units
{
    using System.Text;

    using Common;
    using Common.Enums;
    using Contracts;

    public abstract class ForceUnit : Unit, IBattleUnit
    {
        private TypeOfAttack attackType;
        private string name;

        public ForceUnit(string name) : base(name)
        {
            this.AttackType = attackType;
        }

        public TypeOfAttack AttackType { get; set; }

        public override string Print()
        {
            var stb = new StringBuilder();

            stb.Append(base.Print());
            stb.AppendLine($"Chance for success attack: 1/{(int)this.AttackType}");

            return stb.ToString();
        }
    }
}
