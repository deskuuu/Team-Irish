using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public class Pikeman : ForceUnit
    {        
        TypeOfAttack typeOfAttack;

        public Pikeman(string name, int attack, int defense, int health) : base(name,attack,defense,health)
        {
          
            this.typeOfAttack = TypeOfAttack.MiddleRangeAttack;
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
