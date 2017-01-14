using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Models
{
    public abstract class MagicUnit : Unit
    {
        public MagicUnit(string name) : base(name)
        {
        }
    }
}
