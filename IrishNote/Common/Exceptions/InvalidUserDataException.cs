namespace Common.Exceptions
{
    using System;

    public class InvalidUserDataException : ApplicationException
    {
        private const string Message = "Invalid user data!";

        public InvalidUserDataException() : base(Message)
        {
        }

        public InvalidUserDataException(string message) : base(message)
        {
        }
    }
}
