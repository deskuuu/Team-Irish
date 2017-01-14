using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Contracts
{
    public interface IWriter
    {
        void Write();

        void Write(string message);

        void WriteLine();

        void WriteLine(string message);
    }
}
