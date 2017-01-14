namespace BattleGame.Providers
{
    using System;

    using Contracts;

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
