using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Contracts
{
    public interface IPlayer
    {
        string Name { get; set; }

        IList<IBattleUnit> Army { get; }

        int Points { get; set; }

        void AddUnit(IBattleUnit unitForAdd);

        void RemoveUnit(IBattleUnit unitForRemove);
    }
}
