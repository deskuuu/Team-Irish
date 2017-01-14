using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common;
using BattleGame.Contracts;

namespace BattleGame.Models
{
    public class Player : IPlayer
    {
        private string name;

        private IList<IBattleUnit> army;

        private int points;

        public Player()
        {
            this.name = Constants.DefaultPlayerName;

            this.army = new List<IBattleUnit>();
            
            this.points = 0;
        }

        public IList<IBattleUnit> Army
        {
            get
            {
                return this.army;
            }

            set
            {
                this.army = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
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
            // TODO:
            return base.ToString();
        }
    }
}
