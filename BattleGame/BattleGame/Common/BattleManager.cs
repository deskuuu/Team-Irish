namespace BattleGame.Common
{
    using System;

    using Contracts;

    public class BattleManager : IBattleManager
    {
        public void Battle(IBattleUnit attackUnit, IBattleUnit defenceUnit)
        {
            Random successfulHit = new Random();
            int hitResult = successfulHit.Next(1, (int)attackUnit.AttackType);

            if (hitResult == 1)
            {
                Console.WriteLine(Constants.AttackResultUnsuccesMessage);
            }
            else
            {
                defenceUnit.Health -= attackUnit.Attack;
                Console.WriteLine(Constants.AttackResultSuccesMessage);
            }
        }
    }
}
