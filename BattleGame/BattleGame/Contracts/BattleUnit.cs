using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common.Enums;

namespace BattleGame.Contracts
{
    public interface IBattleUnit
    {
        TypeOfAttack TypeOfAttack { get; }

        int Health { get; set; }

        int Attack { get; }

        int Defence { get; }

    }
}
