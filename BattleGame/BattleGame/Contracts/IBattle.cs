namespace BattleGame.Contracts
{
    public interface IBattleManager
    {
        void Battle(IBattleUnit playerOneUnit, IBattleUnit playerTwoUnit);
    }
}
