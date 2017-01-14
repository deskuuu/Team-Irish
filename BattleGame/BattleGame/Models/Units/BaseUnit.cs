namespace BattleGame.Models.Units
{
    using System;

    using Common;
    using Contracts;

    public class BaseUnit : IBaseUnit
    {
        private string name;

        public BaseUnit(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Constants.InvalidName);
                }

                this.name = value;
            }
        }
    }
}
