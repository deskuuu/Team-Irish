using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;
using BattleGame.Models;
using BattleGame.Providers;

namespace BattleGame.Engine
{
    public sealed class GameEngine : IEngine
    {
        private Player firstPlayer;

        private Player secondPlayer;

        private IReader reder;

        private IWriter writer;

        public GameEngine()
        {
            this.firstPlayer = new Player();
            this.secondPlayer = new Player();

            this.reder = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Start()
        {
            this.writer.WriteLine("Enter first player name: ");
            string firstPlayerName = this.reder.ReadLine();
            this.firstPlayer.Name = firstPlayerName;

            IList<IBattleUnit> firstPlayerArmy = ParseUnits();
            this.firstPlayer.Army = firstPlayerArmy;

            this.writer.WriteLine("Enter second player name: ");
            string secondPlayerName = this.reder.ReadLine();
            this.secondPlayer.Name = secondPlayerName;

            IList<IBattleUnit> secondPlayerArmy = ParseUnits();
            this.secondPlayer.Army = secondPlayerArmy;

            ShowPlayers(this.firstPlayer);
            ShowPlayers(this.secondPlayer);

            //while (true)
            //{
            //    // TODO:
            //    string currentLine = this.reder.ReadLine();


            //    break;
            //}
        }

        private IList<IBattleUnit> ParseUnits()
        {
            this.writer.WriteLine("On next three lines chose units and theirs names in format: <unit> <name>");
            this.writer.WriteLine("'s' -> swordmen  ||  'a' -> archer  ||  'p' -> pikmen  ||  'm' -> magician");
            string firstUnitAsString = this.reder.ReadLine();
            string secondUnitAsString = this.reder.ReadLine();
            string thirdUnitAsString = this.reder.ReadLine();

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
            string[] parts = unitAsString.Split(' ');

            string typeOfUnit = parts[0];
            string name = parts[1];

            IBattleUnit unit = null;

            if (typeOfUnit == "s")
            {
                unit = new Swordman(name);
            }
            else if (typeOfUnit == "a")
            {
                unit = new Archer(name);
            }
            else if (typeOfUnit == "p")
            {
                unit = new Pikman(name);
            }
            else if (typeOfUnit == "m")
            {
                unit = new Magician(name);
            }
            else
            {
                throw new ArgumentException("Invalid unit type!");
            }

            return unit;
        }

        private void ShowPlayers(IPlayer player)
        {
            this.writer.WriteLine(player.Name);

            foreach (var unit in player.Army)
            {
                this.writer.WriteLine(unit.ToString());
            }

            this.writer.WriteLine();
        }
    }
}
