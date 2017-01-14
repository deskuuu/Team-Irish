namespace BattleGame.Engine
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Common.Exceptions;
    using Contracts;
    using Factories;
    using Models;
    using Providers;

    public sealed class GameEngine : IEngine
    {
        private IPlayer firstPlayer;
        private IPlayer secondPlayer;
        private IReader reader;
        private IWriter writer;

        public GameEngine()
        {
            this.firstPlayer = PlayerFactory.CreatePlayer();
            this.secondPlayer = PlayerFactory.CreatePlayer();

            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Start()
        {
            // First player
            this.writer.WriteLine(Constants.FirstPlayerMessage);
            string firstPlayerName = this.reader.ReadLine();
            this.firstPlayer.Name = firstPlayerName;

            IList<IBattleUnit> firstPlayerArmy = this.ParseUnits();
            this.firstPlayer.Army = firstPlayerArmy;

            // Second player
            //this.writer.WriteLine(Constants.SecondPlayerMessage);
            //string secondPlayerName = this.reader.ReadLine();
            //this.secondPlayer.Name = secondPlayerName;

            //IList<IBattleUnit> secondPlayerArmy = ParseUnits();
            //this.secondPlayer.Army = secondPlayerArmy;

            ShowPlayer(this.firstPlayer);
            // ShowPlayer(this.secondPlayer);

            // Game cycle 

            //while (firstPlayerArmy.Count != 0 && secondPlayerArmy.Count != 0)
            //{
            //    string currentLine = this.reader.ReadLine();

            //    break;
            //}
        }

        private IList<IBattleUnit> ParseUnits()
        {
            this.writer.WriteLine(Constants.ChooseUnitsMessage);
            this.writer.WriteLine(Constants.UnitsInformationMessage);

            var firstUnitAsString = this.reader.ReadLine();
            var secondUnitAsString = this.reader.ReadLine();
            var thirdUnitAsString = this.reader.ReadLine();

            IBattleUnit firstUnits = ParseStringToUnit(firstUnitAsString);
            IBattleUnit secondUnits = ParseStringToUnit(secondUnitAsString);
            IBattleUnit thirdUnits = ParseStringToUnit(thirdUnitAsString);

            IList<IBattleUnit> result = new List<IBattleUnit>();
            result.Add(firstUnits);
            result.Add(secondUnits);
            result.Add(thirdUnits);

            return result;
        }

        private IBattleUnit ParseStringToUnit(string unitAsString)
        {
            var parts = unitAsString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            var typeOfUnit = parts[0].ToLower();
            var name = parts[1];
            IBattleUnit unit = null;

            switch (typeOfUnit)
            {
                case "a": unit = UnitFactory.CreateArcher(name); break;
                case "s": unit = UnitFactory.CreateSwordman(name); break;
                case "m": unit = UnitFactory.CreateMagician(name); break;
                case "p": unit = UnitFactory.CreatePikeman(name); break;
                default: throw new ArgumentException(Constants.InvalidUnitType);
            }

            if (unit == null)
            {
                throw new InvalidUnitException();
            }

            return unit;
        }

        private void ShowPlayer(IPlayer player)
        {
            this.writer.WriteLine(player.Name);

            foreach (var unit in player.Army)
            {
                this.writer.WriteLine(unit.Print());
            }
        }
    }
}
