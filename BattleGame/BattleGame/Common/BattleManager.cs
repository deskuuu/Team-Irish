namespace BattleGame.Common
{
    using System;

    using Contracts;

    public class BattleManager : IBattle
    {
        public void Battle(IBattleUnit playerOneUnit, IBattleUnit playerTwoUnit)
        {
            Random successfulHit = new Random();
            int hitResult = successfulHit.Next(0, 2);
            if (hitResult == 0)
            {
                Console.WriteLine("Attack was unsuccessful!");
            }
            else
            {
                playerTwoUnit.Health -= playerOneUnit.Attack;
                Console.WriteLine("Attack was successful!");
            }
        }
    }
}
