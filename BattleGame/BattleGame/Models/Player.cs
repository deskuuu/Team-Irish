namespace BattleGame.Models
{
    using System.Collections.Generic;

    using Common;
    using Contracts;
    using Units;

    public class Player : BaseUnit, IPlayer
    {
        public IList<IBattleUnit> Army { get; set; }

        public int Points { get; set; }

        public Player(string name = Constants.DefaultPlayerName) : base(name)
        {
            this.Army = new List<IBattleUnit>();
            this.Points = Constants.DefaultPlayerPoints;
        }

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
            return $"PLAYER NAME: {this.Name}";
        }
    }
}
