namespace BattleGame.Contracts
{
    using System.Collections.Generic;

    public interface IUnitParser
    {
        IBattleUnit ParseStringToUnit(string unitAsString);

        IList<IBattleUnit> ParseUnits();
    }
}
