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
        int Health { get; }

        int Attack { get; }

        int Defense { get; }

    }
}
