using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;
using BattleGame.Engine;

namespace BattleGame
{
    public class Startup
    {
        public static void Main()
        {
            IEngine engine = new GameEngine();
            engine.Start();
        }
    }
}
