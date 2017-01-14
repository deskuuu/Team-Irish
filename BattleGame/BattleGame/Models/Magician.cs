using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public class Magician : MagicUnit, IBattleUnit
    {
        private int attack;
        private int defence;
        private int health;
        TypeOfAttack typeOfAttack;

        public Magician(string name) : base(name)
        {
            this.Attack = 40;
            this.Defence = 10;
            this.Health = 80;
            this.typeOfAttack = TypeOfAttack.Magic;
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
