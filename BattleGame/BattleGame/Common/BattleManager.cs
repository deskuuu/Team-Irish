namespace BattleGame.Common
{
    using System;
    using System.Threading;

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
            var successfulHit = new Random();
            var hitResult = successfulHit.Next(1, (int)attackUnit.AttackType);

            if (hitResult == 1)
            {
                this.writer.WriteLine(Constants.AttackResultUnsuccesMessage);
                Thread.Sleep(2400);
            }
            else
            {
                defenceUnit.Health -= attackUnit.Attack;
                this.writer.WriteLine(Constants.AttackResultSuccesMessage);
                Thread.Sleep(2400);
            }
        }
    }
}