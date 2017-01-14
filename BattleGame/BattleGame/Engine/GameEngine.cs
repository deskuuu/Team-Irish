using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Contracts;
using BattleGame.Models;
using BattleGame.Providers;
using BattleGame.Common;

namespace BattleGame.Engine
{
    public sealed class GameEngine : IEngine
    {
        private Player firstPlayer;

        private Player secondPlayer;

        private IReader reader;

        private IWriter writer;

        public GameEngine()
        {
            this.firstPlayer = new Player();
            this.secondPlayer = new Player();

            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Start()
        {
            this.writer.WriteLine("Enter first player name: ");
            string firstPlayerName = this.reader.ReadLine();
            this.firstPlayer.Name = firstPlayerName;

            IList<IBattleUnit> firstPlayerArmy = ParseUnits();
            this.firstPlayer.Army = firstPlayerArmy;

            this.writer.WriteLine("Enter second player name: ");
            string secondPlayerName = this.reader.ReadLine();
            this.secondPlayer.Name = secondPlayerName;

            IList<IBattleUnit> secondPlayerArmy = ParseUnits();
            this.secondPlayer.Army = secondPlayerArmy;

            ShowPlayers(this.firstPlayer);
            ShowPlayers(this.secondPlayer);

            while (firstPlayerArmy.Count != 0 && secondPlayerArmy.Count != 0)
            {
                string currentLine = this.reader.ReadLine();

                break;
            }
        }

        private IList<IBattleUnit> ParseUnits()
        {
            this.writer.WriteLine("On next three lines chose units and theirs names in format: <unit> <name>");
            this.writer.WriteLine("'s' -> swordmen  ||  'a' -> archer  ||  'p' -> pikmen  ||  'm' -> magician");
            string firstUnitAsString = this.reader.ReadLine();
            string secondUnitAsString = this.reader.ReadLine();
            string thirdUnitAsString = this.reader.ReadLine();

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
                unit = new Swordman
                    (name, Constants.SwordmanAttack, Constants.SwordmanDefense, Constants.SwordmanHealth);
            }
            else if (typeOfUnit == "a")
            {
                unit = new Archer
                     (name, Constants.ArcherAttack, Constants.ArcherDefense, Constants.ArcherHealth);
            }
            else if (typeOfUnit == "p")
            {
                unit = new Pikeman
                    (name, Constants.PikemanAttack, Constants.PikemanDefense, Constants.PikemanHealth);
            }
            else if (typeOfUnit == "m")
            {
                unit = new Magician
                    (name, Constants.MagicianAttack, Constants.MagicianDefense, Constants.MagicianHealth);
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
        }
    }
}
