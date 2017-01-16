namespace BattleGame.Models.Units
{
    using System;
    using System.Text;

    using Common;

    public abstract class Unit : BaseUnit
    {
        private int attack;
        private int defense;
        private int health;

        public Unit(string name) : base(name)
        {
            this.Attack = this.attack;
            this.Defense = this.defense;
            this.Health = this.health;
        }

        public int Attack
        {
            get
            {
                return this.attack;
            }

            set
            {
                this.Validator(value);

                this.attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return this.defense;
            }

            set
            {
                this.Validator(value);

                this.defense = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                this.health = value;
            }
        }

        public virtual string Print()
        {
            var stb = new StringBuilder();

            stb.AppendLine($"{Constants.NameMessage} {this.Name}");
            stb.AppendLine($"{Constants.AttackMessage} {this.Attack}");
            stb.AppendLine($"{Constants.DefenseMessage} {this.Defense}");
            stb.AppendLine($"{Constants.HealthMessage} {this.Health}");

            return stb.ToString();
        }

        private void Validator(int value)
        {
            if (value < Constants.MinValue)
            {
                throw new ArgumentOutOfRangeException(Constants.InvalidValueMessage);
            }
        }
    }
}
