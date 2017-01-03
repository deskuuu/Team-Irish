namespace IrishNote
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class InvalidAboutHyperLinkException : ApplicationException
    {
        public InvalidAboutHyperLinkException()
        {
        }

        public InvalidAboutHyperLinkException(string message) : base(message)
        {
        }

        public InvalidAboutHyperLinkException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAboutHyperLinkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}