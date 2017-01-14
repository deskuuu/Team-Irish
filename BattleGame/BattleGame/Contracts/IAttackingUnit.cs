using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;

namespace BattleGame.Contracts
{
    public interface IAttackingUnit
    {
        TypeOfAttack AttackType { get; set; }
    }
}
