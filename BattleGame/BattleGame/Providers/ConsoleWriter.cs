﻿namespace BattleGame.Providers
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

        public void WriteLineInYellow(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WriteLineInGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WriteLineInRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void WriteLine(string[] lines)
        {
            foreach (var text in lines)
            {
                var currentCol = (Console.WindowWidth / 2) - (text.Length / 2) + 1;
                Console.Write(new string(' ', currentCol));
                Console.WriteLine(text);
            }
        }
    }
}
