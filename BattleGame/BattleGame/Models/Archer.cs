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
    public class Archer : ForceUnit
    {
        
        TypeOfAttack typeOfAttack;

        public Archer(string name, int attack, int defense, int health) 
            : base(name, attack, defense, health)
        {
           
            typeOfAttack = TypeOfAttack.LongRangeAttack;
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
