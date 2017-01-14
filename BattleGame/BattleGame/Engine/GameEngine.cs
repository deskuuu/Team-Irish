namespace BattleGame.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
            Console.Clear();

            ShowPlayer(this.firstPlayer);
            ShowPlayer(this.secondPlayer);

            // for quick tests

            //    Pesho
            //    a Ivancho1
            //    s Ivancho2
            //    m Ivancho3
            //    Gosho
            //    a Dragan1
            //    s Dragan2
            //    p Dragan3

            // Game cycle 
            var isFirstPlayerTurn = true;
            while (this.firstPlayer.Army.Count != 0 && this.secondPlayer.Army.Count != 0)
            {
                if (isFirstPlayerTurn)
                {
                    this.writer.WriteLine(Constants.FirstPlayerTurnMessage);

                    string currentCommand = this.reader.ReadLine();
                    int[] parts = currentCommand.Split(' ').Select(x => int.Parse(x)).ToArray();
                    int attackUnitIndex = parts[0] - 1;
                    int defendUnitIndex = parts[1] - 1;
                    IBattleUnit attacker = this.firstPlayer.Army[attackUnitIndex];
                    IBattleUnit defender = this.secondPlayer.Army[defendUnitIndex];

                    this.battleManager.Battle(attacker, defender);

                    if (this.firstPlayer.Army[defendUnitIndex].Health <= 0)
                    {
                        this.writer.WriteLineInRed(Constants.UnitIsDead);
                        this.firstPlayer.Army.Remove(defender);
                    }

                    ShowPlayer(this.firstPlayer);
                    ShowPlayer(this.secondPlayer);
                }
                else
                {
                    this.writer.WriteLine(Constants.SecondPlayerTurnMessage);

                    string currentCommand = this.reader.ReadLine();
                    int[] parts = currentCommand.Split(' ').Select(x => int.Parse(x)).ToArray();
                    int attackUnitIndex = parts[0] - 1;
                    int defendUnitIndex = parts[1] - 1;
                    IBattleUnit attacker = this.secondPlayer.Army[attackUnitIndex];
                    IBattleUnit defender = this.firstPlayer.Army[defendUnitIndex];

                    this.battleManager.Battle(attacker, defender);

                    if (this.secondPlayer.Army[defendUnitIndex].Health <= 0)
                    {
                        this.writer.WriteLineInRed(Constants.UnitIsDead);
                        this.secondPlayer.Army.Remove(defender);
                    }

                    ShowPlayer(this.firstPlayer);
                    ShowPlayer(this.secondPlayer);
                }

                // change turn
                isFirstPlayerTurn = !isFirstPlayerTurn;
            }
        }

        private void ShowPlayer(IPlayer player)
        {
            this.writer.WriteLineInYellow(player.ToString());

            foreach (var unit in player.Army)
            {
                this.writer.WriteLineInGreen(unit.Print());
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
