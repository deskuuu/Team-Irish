namespace BattleGame.Models.Units
{
    using System;
    using System.Text;

    using Common;
    using Contracts;

    public abstract class Unit : IUnit
    {
        private string name;
        private int attack;
        private int defense;
        private int health;

        public Unit(string name)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.Health = health;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Constants.InvalidName);
                }

                this.name = value;
            }
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
                this.Validator(value);

                this.health = value;
            }
        }

        public virtual string Print()
        {
            var stb = new StringBuilder();

            stb.AppendLine($"Name: {this.Name}");
            stb.AppendLine($"Attack: {this.Attack}");
            stb.AppendLine($"Defense: {this.Defense}");
            stb.AppendLine($"Health: {this.Health}");

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
