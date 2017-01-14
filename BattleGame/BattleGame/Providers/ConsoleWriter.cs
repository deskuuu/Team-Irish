using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;

namespace BattleGame.Providers
{
    public class ConsoleWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine();
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
