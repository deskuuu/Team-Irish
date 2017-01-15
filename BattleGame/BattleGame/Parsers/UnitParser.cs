using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Common;
using BattleGame.Common.Exceptions;
using BattleGame.Contracts;
using BattleGame.Factories;
using BattleGame.Providers;

namespace BattleGame.Parsers
{
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
                case "a": unit = UnitFactory.CreateArcher(name); break;
                case "s": unit = UnitFactory.CreateSwordman(name); break;
                case "m": unit = UnitFactory.CreateMagician(name); break;
                case "p": unit = UnitFactory.CreatePikeman(name); break;
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

            IBattleUnit firstUnits = ParseStringToUnit(firstUnitAsString);
            IBattleUnit secondUnits = ParseStringToUnit(secondUnitAsString);
            IBattleUnit thirdUnits = ParseStringToUnit(thirdUnitAsString);

            IList<IBattleUnit> result = new List<IBattleUnit>();
            result.Add(firstUnits);
            result.Add(secondUnits);
            result.Add(thirdUnits);

            return result;
        }
    }
}
