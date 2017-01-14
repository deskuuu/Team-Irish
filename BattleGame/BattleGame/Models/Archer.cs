using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;
using BattleGame.Contracts;
using BattleGame.Models;

namespace BattleGame.Models
{
    public class Archer : ForceUnit, IBattleUnit
    {
        private int attack;
        private int defence;
        private int health;
        TypeOfAttack typeOfAttack;

        public Archer(string name) : base(name)
        {
            this.attack = 40;
            this.defence = 20;
            this.health = 50;
            typeOfAttack = TypeOfAttack.LongRangeAttack;
        }

        public int Attack
        {
            get
            {
                return this.attack;
            }
            private set
            {
                this.attack = value;
            }
        }

        public int Defence
        {
            get
            {
                return this.defence;
            }
            private set
            {
                this.defence = value;
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

        public TypeOfAttack TypeOfAttack
        {
            get
            {
                return this.typeOfAttack;
            }
        }

        public override string ToString()
        {
            // TODO:
            return base.ToString();
        }
    }
}
