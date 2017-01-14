using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public abstract class ForceUnit : Unit, IBattleUnit
    {
        private int attack;
        private int defense;
        private int health;

        public ForceUnit(string name,int attack,int defense,int health) : base(name)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.Health = health;
        }
        public int Attack
        {
            get
            {
                return this.attack;
            }
            protected set
            {
                this.attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return this.defense;
            }
            protected set
            {
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

        public override string ToString()
        {
            var stb = new StringBuilder();

            stb.AppendLine(base.ToString());
            stb.AppendLine($"Attack: {this.Attack}");
            stb.AppendLine($"Defense: {this.Defense}");
            stb.Append($"Health: {this.Health}");

            return stb.ToString();
        }

    }
}
