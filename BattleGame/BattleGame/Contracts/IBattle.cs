namespace BattleGame.Contracts
{
    public interface IBattle
    {
        void Battle(IBattleUnit playerOneUnit, IBattleUnit playerTwoUnit);
    }
}
