namespace BattleGame.Common
{
    public sealed class Constants
    {
        public const string DefaultPlayerName = "Player";
        public const string FirstPlayerMessage = "Enter first player name: ";
        public const string SecondPlayerMessage = "Enter second player name: ";
        public const string ChooseUnitsMessage = "On next lines chose three units and give them names in format: <unit> <name>";
        public const string UnitsInformationMessage = "'s' -> swordmen  ||  'a' -> archer  ||  'p' -> pikmen  ||  'm' -> magician";
        public const string InvalidName = "Invalid name";
        public const string InvalidUnitType = "Invalid unit type!";
        public const int MinValue = 0;
        public const string InvalidValueMessage = "This value must be greather than 0!";
        public const string InvalidUnitException = "Invalid unit!";
        public const int DefaultPlayerPoints = 0;

        public const string AttackResultSuccesMessage = "Attack was successful!";
        public const string AttackResultUnsuccesMessage = "Attack was unsuccessful!";

        public const string NameMessage = "Name:";
        public const string AttackMessage = "Attack:";
        public const string DefenseMessage = "Defense: ";
        public const string HealthMessage = "Health: ";
        public const string AttackTypeMessage = "Type of attack:";

        //Swordman stats
        public const int SwordmanAttack = 20;
        public const int SwordmanDefense = 40;
        public const int SwordmanHealth = 30;

        //Archer stats
        public const int ArcherAttack = 22;
        public const int ArcherDefense = 44;
        public const int ArcherHealth = 35;

        //Pikeman stats
        public const int PikemanAttack = 25;
        public const int PikemanDefense = 41;
        public const int PikemanHealth = 32;

        //Magician stats
        public const int MagicianAttack = 27;
        public const int MagicianDefense = 50;
        public const int MagicianHealth = 45;
    }
}
