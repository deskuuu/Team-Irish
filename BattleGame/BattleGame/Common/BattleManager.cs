using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;

namespace BattleGame.Common
{
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
