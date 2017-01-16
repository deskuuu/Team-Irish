namespace BattleGame.Models
{
    using System.Collections.Generic;

    using Common;
    using Contracts;
    using Units;

    public class Player : BaseUnit, IPlayer
    {
        public Player(string name = Constants.DefaultPlayerName) : base(name)
        {
            this.Army = new List<IBattleUnit>();
            this.Points = Constants.DefaultPlayerPoints;
        }

        public IList<IBattleUnit> Army { get; set; }

        public int Points { get; set; }

        public void AddUnit(IBattleUnit unitForAdd)
        {
            this.Army.Add(unitForAdd);
        }

        public void RemoveUnit(IBattleUnit unitForRemove)
        {
            this.Army.Remove(unitForRemove);
        }

        public override string ToString()
        {
            return $"{Constants.PlayerNameMessage} {this.Name}";
        }
    }
}
