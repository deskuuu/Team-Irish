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
    using Parsers;
    using Providers;
    using System.IO;

    public sealed class GameEngine : IEngine
    {
        private static IEngine instanceHolder = new GameEngine();

        private IPlayer firstPlayer;
        private IPlayer secondPlayer;
        private IBattleManager battleManager;
        private IUnitParser unitParser;
        private IReader reader;
        private IWriter writer;

        private GameEngine()
        {
            this.firstPlayer = PlayerFactory.CreatePlayer();
            this.secondPlayer = PlayerFactory.CreatePlayer();
            this.battleManager = new BattleManager();
            this.unitParser = new UnitParser();
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();

            var backgroundMusicPlayer = new MusicPlayer(Constants.MusicPath);
            backgroundMusicPlayer.PlayLooping();
        }

        public static IEngine Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public event EngineMessage OnEngineMessageEvent;

        public void Start()
        {
            this.SetupConsol();            
            this.InitializePlayerUnits(this.firstPlayer, Constants.FirstPlayerMessage);
            this.InitializePlayerUnits(this.secondPlayer, Constants.SecondPlayerMessage);
            Console.Clear();

            this.ShowPlayers(this.firstPlayer, this.secondPlayer);

            // Game cycle 
            var isFirstPlayerTurn = true;
            while (this.firstPlayer.Army.Count != 0 && this.secondPlayer.Army.Count != 0)
            {
                if (isFirstPlayerTurn)
                {
                    this.writer.WriteLine(string.Format(Constants.PlayerTurnMessage, this.firstPlayer.Name));

                    var currentCommand = this.reader.ReadLine().Trim();
                    var parts = currentCommand.Split(' ').Select(x => int.Parse(x)).ToArray();
                    if (parts.Length != 2 || parts[0] < 1 || parts[0] > this.firstPlayer.Army.Count || parts[1] < 1 || parts[1] > this.secondPlayer.Army.Count)
                    {
                        throw new InvalidAttackException();
                    }

                    var attackUnitIndex = parts[0] - 1;
                    var defendUnitIndex = parts[1] - 1;
                    var attacker = this.firstPlayer.Army[attackUnitIndex];
                    var defender = this.secondPlayer.Army[defendUnitIndex];

                    this.battleManager.Battle(attacker, defender);

                    if (this.firstPlayer.Army[defendUnitIndex].Health <= 0)
                    {
                        this.writer.WriteLineInRed(Constants.UnitIsDead);
                        this.firstPlayer.Army.Remove(defender);
                    }

                    this.CheckForDeadUnit(this.secondPlayer);

                    this.ShowPlayers(this.firstPlayer, this.secondPlayer);
                }
                else
                {
                    this.writer.WriteLine(string.Format(Constants.PlayerTurnMessage, this.secondPlayer.Name));

                    var currentCommand = this.reader.ReadLine();
                    var parts = currentCommand.Split(' ').Select(x => int.Parse(x)).ToArray();
                    var attackUnitIndex = parts[0] - 1;
                    var defendUnitIndex = parts[1] - 1;
                    var attacker = this.secondPlayer.Army[attackUnitIndex];
                    var defender = this.firstPlayer.Army[defendUnitIndex];

                    this.battleManager.Battle(attacker, defender);

                    this.CheckForDeadUnit(this.firstPlayer);
                    this.ShowPlayers(this.firstPlayer, this.secondPlayer);
                }

                // change turn
                isFirstPlayerTurn = !isFirstPlayerTurn;
            }

            if (this.firstPlayer.Army.Count == 0)
            {
                this.ShowPlayer(this.secondPlayer);
                this.FinalMessage(Constants.SecondPlayerWinMessage, this.secondPlayer);
            }
            else
            {
                this.ShowPlayer(this.firstPlayer);
                this.FinalMessage(Constants.FirstPlayerWinMessage, this.firstPlayer);
            }

            this.OnEngineMessageEvent?.Invoke(Constants.EndMessage);
        }

        private void ShowPlayer(IPlayer player)
        {
            this.writer.Clear();

            this.writer.WriteLineInYellow(player.ToString());

            foreach (var unit in player.Army)
            {
                this.writer.WriteLineInGreen(unit.Print());
            }
        }

        private void SetupConsol()
        {
            Console.Title = Constants.GameTitle;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void CheckForDeadUnit(IPlayer player)
        {
            IList<IBattleUnit> changedArmy = new List<IBattleUnit>();

            foreach (IBattleUnit unit in player.Army)
            {
                if (unit.Health <= 0)
                {
                    this.writer.WriteLineInRed(string.Format(Constants.UnitIsDead, unit.Name));
                    Thread.Sleep(4800);
                }
                else
                {
                    changedArmy.Add(unit);
                }
            }

            player.Army = changedArmy;

            this.ShowPlayers(this.firstPlayer, this.secondPlayer);
        }

        private void FinalMessage(string winMessage, IPlayer player)
        {
            this.writer.WriteLine(string.Format(winMessage, player.Name));
            this.writer.WriteLineInGreen(string.Format(winMessage, player.Name));
            this.writer.WriteLineInRed(string.Format(winMessage, player.Name));
            Thread.Sleep(5000);
        }

        private void ShowPlayers(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            this.writer.Clear();

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
            var playerName = this.reader.ReadLine();
            player.Name = playerName;

            IList<IBattleUnit> playerArmy = this.unitParser.ParseUnits();
            player.Army = playerArmy;
        }
    }
}
