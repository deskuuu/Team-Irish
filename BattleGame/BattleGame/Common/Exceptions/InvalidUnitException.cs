namespace BattleGame.Common.Exceptions
{
    using System;

    public class InvalidUnitException : ApplicationException
    {
        public InvalidUnitException() : base()
        {
        }

        public InvalidUnitException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return Constants.InvalidUnitException;
            }
        }
    }
}
