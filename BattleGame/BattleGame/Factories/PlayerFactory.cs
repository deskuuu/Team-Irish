using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;
using BattleGame.Models;

namespace BattleGame.Factories
{
    public static class PlayerFactory
    {
        public static IPlayer CreatePlayer()
        {
            return new Player();
        }
    }
}
