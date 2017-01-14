namespace BattleGame.Common
{
    using System;

    using Contracts;
    using Providers;

    public class BattleManager : IBattleManager
    {
        private IWriter writer;

        public BattleManager()
        {
            this.writer = new ConsoleWriter();
        }

        public void Battle(IBattleUnit attackUnit, IBattleUnit defenceUnit)
        {
            Random successfulHit = new Random();
            int hitResult = successfulHit.Next(1, (int)attackUnit.AttackType);

            if (hitResult == 1)
            {
                this.writer.WriteLine(Constants.AttackResultUnsuccesMessage);
            }
            else
            {
                defenceUnit.Health -= attackUnit.Attack;
                this.writer.WriteLine(Constants.AttackResultSuccesMessage);
            }
        }
    }
}
