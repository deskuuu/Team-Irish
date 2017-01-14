namespace BattleGame.Contracts
{
    public interface IUnit
    {
        string Name { get; set; }

        int Attack { get; set; }

        int Defense { get; set; }

        string Print();
    }
}
