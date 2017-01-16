namespace BattleGame.Common.Exceptions
{
    using System;

    public class InvalidAttackException : ApplicationException
    {
        public InvalidAttackException()
        {
        }

        public InvalidAttackException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return Constants.InvalidAttackAction;
            }
        }
    }
}
