namespace BattleGame.Contracts
{
    using System.Collections.Generic;

    public interface IPlayer : IBaseUnit
    {
        IList<IBattleUnit> Army { get; set; }

        int Points { get; set; }

        void AddUnit(IBattleUnit unitForAdd);

        void RemoveUnit(IBattleUnit unitForRemove);
    }
}
