using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public abstract class MagicUnit : Unit, IBattleUnit
    {
        private int attack;
        private int defense;
        private int health;

        public MagicUnit(string name,int attack,int defense,int health) : base(name)
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

    }
}
