namespace Common.Exceptions
{
    public class InvalidUsernameException : InvalidUserDataException
    {
        private const string Message = "Invalid username!";

        public InvalidUsernameException() : base(Message)
        {
        }

        public InvalidUsernameException(string message) : base(message)
        {
        }
    }
}
