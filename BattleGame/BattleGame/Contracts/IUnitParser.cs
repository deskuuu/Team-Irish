using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Contracts
{
    public interface IUnitParser
    {
        IBattleUnit ParseStringToUnit(string unitAsString);

        IList<IBattleUnit> ParseUnits();
    }
}
