using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public class Swordman : ForceUnit, IBattleUnit
    {       
        TypeOfAttack typeOfAttack;

        public Swordman(string name,int attack, int defense, int health)
            : base(name,attack,defense,health)
        {           
            this.typeOfAttack = TypeOfAttack.BrutalForce;
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
            var stb = new StringBuilder();

            stb.AppendLine(base.ToString());
            stb.AppendLine($"Type Of Attak: {this.TypeOfAttack}");

            return stb.ToString();
        }
    }
}
