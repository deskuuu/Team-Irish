namespace BattleGame.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
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

            ShowPlayers(this.firstPlayer, this.secondPlayer);

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
                    if (parts.Length != 2 || parts[0] < 1 || parts[0] > firstPlayer.Army.Count || parts[1] < 1 || parts[1] > secondPlayer.Army.Count)
                    {
                        throw new InvalidAttackException();
                    }
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

                    CheckForDeadUnit(this.secondPlayer);

                    ShowPlayers(this.firstPlayer, this.secondPlayer);
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

                    CheckForDeadUnit(this.firstPlayer);
                    ShowPlayers(this.firstPlayer, this.secondPlayer);

                }

                // change turn
                isFirstPlayerTurn = !isFirstPlayerTurn;
            }

            if (this.firstPlayer.Army.Count == 0)
            {
                FinalMessage(Constants.SecondPlayerWinMessage);
            }
            else
            {
                FinalMessage(Constants.FirstPlayerWinMessage);
            }
        }

        private void CheckForDeadUnit(IPlayer player)
        {
            IList<IBattleUnit> changedArmy = new List<IBattleUnit>();

            foreach (IBattleUnit unit in player.Army)
            {
                if (unit.Health <= 0)
                {
                    this.writer.WriteLineInRed(Constants.UnitIsDead);
                }
                else
                {
                    changedArmy.Add(unit);
                }
            }

            player.Army = changedArmy;

            ShowPlayers(this.firstPlayer, this.secondPlayer);
        }

        private void FinalMessage(string winMessage)
        {
            this.writer.WriteLine(winMessage);
            this.writer.WriteLineInGreen(winMessage);
            this.writer.WriteLineInRed(winMessage);
            Thread.Sleep(1000);
        }

        private void ShowPlayers(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            // first player
            this.writer.WriteLineInYellow(firstPlayer.ToString());

            foreach (var unit in firstPlayer.Army)
            {
                this.writer.WriteLineInGreen(unit.Print());
            }

            // second player
            this.writer.WriteLineInYellow(secondPlayer.ToString());

            foreach (var unit in secondPlayer.Army)
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
