namespace BattleGame.Parsers
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Common.Exceptions;
    using Contracts;
    using Factories;
    using Providers;

    public class UnitParser : IUnitParser
    {
        private IWriter writer;
        private IReader reader;

        public UnitParser()
        {
            this.writer = new ConsoleWriter();
            this.reader = new ConsoleReader();
        }

        public IBattleUnit ParseStringToUnit(string unitAsString)
        {
            var parts = unitAsString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                throw new InvalidUnitException();
            }

            var typeOfUnit = parts[0].ToLower();
            var name = parts[1];
            IBattleUnit unit = null;

            switch (typeOfUnit)
            {
                case Constants.AChoice:
                    unit = UnitFactory.CreateArcher(name);
                    break;
                case Constants.SChoice:
                    unit = UnitFactory.CreateSwordman(name);
                    break;
                case Constants.MChoice:
                    unit = UnitFactory.CreateMagician(name);
                    break;
                case Constants.PChoice:
                    unit = UnitFactory.CreatePikeman(name);
                    break;
                   default: throw new InvalidUnitException();
            }

            return unit;
        }

        public IList<IBattleUnit> ParseUnits()
        {
            this.writer.WriteLine(Constants.ChooseUnitsMessage);
            this.writer.WriteLine(Constants.UnitsInformationMessage);

            var firstUnitAsString = this.reader.ReadLine();
            var secondUnitAsString = this.reader.ReadLine();
            var thirdUnitAsString = this.reader.ReadLine();

            var firstUnits = this.ParseStringToUnit(firstUnitAsString);
            var secondUnits = this.ParseStringToUnit(secondUnitAsString);
            var thirdUnits = this.ParseStringToUnit(thirdUnitAsString);

            var result = new List<IBattleUnit>();
            result.Add(firstUnits);
            result.Add(secondUnits);
            result.Add(thirdUnits);

            return result;
        }
    }
}
