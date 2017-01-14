using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public abstract class ForceUnit : Unit
    {
        public ForceUnit(string name) : base(name)
        {
        }
    }
}
