namespace BattleGame.Common.Exceptions
{
    using System;

    public class InvalidUnitException : ApplicationException
    {
        private const string Message = Constants.InvalidUnitException;

        public InvalidUnitException() : base(Message)
        {
        }

        public InvalidUnitException(string message) : base(message)
        {
        }
    }
}
