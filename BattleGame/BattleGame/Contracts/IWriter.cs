﻿namespace BattleGame.Contracts
{
    public interface IWriter
    {
        void Write();

        void Write(string message);

        void WriteLine();

        void WriteLine(string message);
    }
}
