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
            InitializePlayerUnits(this.firstPlayer, Constants.FirstPlayerMessage);
            InitializePlayerUnits(this.secondPlayer, Constants.SecondPlayerMessage);

            ShowPlayer(this.firstPlayer);
            ShowPlayer(this.secondPlayer);

            // Game cycle 
            var isFirstPlayerTurn = true;
            while (this.firstPlayer.Army.Count != 0 && this.secondPlayer.Army.Count != 0)
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

        private void InitializePlayerUnits(IPlayer player, string message)
        {
            this.writer.WriteLine(message);
            string playerName = this.reader.ReadLine();
            player.Name = playerName;

            IList<IBattleUnit> PlayerArmy = this.unitParser.ParseUnits();
            player.Army = PlayerArmy;
        }
    }
}
