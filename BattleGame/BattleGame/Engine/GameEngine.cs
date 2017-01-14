namespace BattleGame.Engine
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Common.Exceptions;
    using Contracts;
    using Factories;
    using Models;
    using Parsers;
    using Providers;

    public sealed class GameEngine : IEngine
    {
        private IPlayer firstPlayer;
        private IPlayer secondPlayer;
        private IBattleManager battleManager;
        private IUnitParser unitParser;
        private IReader reader;
        private IWriter writer;

        public GameEngine()
        {
            this.firstPlayer = PlayerFactory.CreatePlayer();
            this.secondPlayer = PlayerFactory.CreatePlayer();
            this.battleManager = new BattleManager();
            this.unitParser = new UnitParser();
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Start()
        {
            // First player
            this.writer.WriteLine(Constants.FirstPlayerMessage);
            string firstPlayerName = this.reader.ReadLine();
            this.firstPlayer.Name = firstPlayerName;

            IList<IBattleUnit> firstPlayerArmy = this.unitParser.ParseUnits();
            this.firstPlayer.Army = firstPlayerArmy;

            // Second player 
            this.writer.WriteLine(Constants.SecondPlayerMessage);
            string secondPlayerName = this.reader.ReadLine();
            this.secondPlayer.Name = secondPlayerName;

            IList<IBattleUnit> secondPlayerArmy = this.unitParser.ParseUnits();
            this.secondPlayer.Army = secondPlayerArmy;

            ShowPlayer(this.firstPlayer);
            ShowPlayer(this.secondPlayer);

            // Game cycle 
            var isFirstPlayerTurn = true;
            while (firstPlayerArmy.Count != 0 && secondPlayerArmy.Count != 0)
            {

                if (isFirstPlayerTurn)
                {
                    // this.battleManager.Battle();
                }
                else
                {

                }

                string currentLine = this.reader.ReadLine();

                break;
            }
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
