namespace Common.Exceptions
{
    public class InvalidPasswordException : InvalidUserDataException
    {
        private const string Message = "Invalid password!";

        public InvalidPasswordException() : base(Message)
        {
        }

        public InvalidPasswordException(string message) : base(message)
        {
        }
    }
}
