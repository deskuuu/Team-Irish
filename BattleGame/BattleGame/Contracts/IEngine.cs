namespace BattleGame.Contracts
{
    public delegate void EngineMessage(string message);

    public interface IEngine
    {
        event EngineMessage OnEngineMessageEvent;
        void Start();
    }
}
