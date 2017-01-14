namespace BattleGame.Contracts
{
    public interface IUnit : IBaseUnit
    {
        int Attack { get; set; }

        int Defense { get; set; }

        string Print();
    }
}