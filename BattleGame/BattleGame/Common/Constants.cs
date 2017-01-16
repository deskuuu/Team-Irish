namespace BattleGame.Common
{
    public sealed class Constants
    {
        public const string GameTitle = "Battle-Game";
        public const string DefaultPlayerName = "Player";
        public const string FirstPlayerMessage = "Enter first player name: ";
        public const string SecondPlayerMessage = "Enter second player name: ";
        public const string ChooseUnitsMessage = "On next lines choose three units and give them names in format: <unit> <name>";
        public const string UnitsInformationMessage = "'s' -> swordman  ||  'a' -> archer  ||  'p' -> pikeman  ||  'm' -> magician";
        public const string MusicPath = ".\\Media\\music.wav";
        public const string WelcomePath = ".\\Media\\Logo.txt";

        public const string AChoice = "a";
        public const string SChoice = "s";
        public const string MChoice = "m";
        public const string PChoice = "p";

        public const string InvalidName = "Invalid name";
        public const string InvalidUnitType = "Invalid unit type!";
        public const int MinValue = 0;
        public const string InvalidValueMessage = "This value must be greater than 0!";
        public const string InvalidUnitException = "Invalid unit!";
        public const string InvalidAttackAction = "Invalid attack input!";
        public const int DefaultPlayerPoints = 0;

        public const string PlayerNameMessage = "PLAYER NAME:";
        public const string ChanseForAttackMessage = "Chance for success attack: 1/";
        public const string AttackResultSuccesMessage = "Attack was successful!";
        public const string AttackResultUnsuccesMessage = "Attack was unsuccessful!";

        //// Battle messages
        public const string UnitIsDead = "{0} is dead!";
        public const string FirstPlayerWinMessage = "**** {0} WINS ****";
        public const string SecondPlayerWinMessage = "**** {0} WINS ****";

        //// Turn messages
        public const string PlayerTurnMessage = "{0} is on TURN...";

        public const string NameMessage = "Name:";
        public const string AttackMessage = "Attack:";
        public const string DefenseMessage = "Defense: ";
        public const string HealthMessage = "Health: ";
        public const string AttackTypeMessage = "Type of attack:";

        ////Swordman stats
        public const int SwordmanAttack = 20;
        public const int SwordmanDefense = 40;
        public const int SwordmanHealth = 30;

        ////Archer stats
        public const int ArcherAttack = 22;
        public const int ArcherDefense = 44;
        public const int ArcherHealth = 35;

        ////Pikeman stats
        public const int PikemanAttack = 25;
        public const int PikemanDefense = 41;
        public const int PikemanHealth = 32;

        ////Magician stats
        public const int MagicianAttack = 27;
        public const int MagicianDefense = 50;
        public const int MagicianHealth = 45;

        ////Game End Message
        public const string EndMessage = "This is THE END OF THE GAME!!!";
    }
}
