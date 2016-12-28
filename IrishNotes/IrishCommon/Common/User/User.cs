namespace IrishNotes.Common.User
{
    using System;
    using System.Text;

    using Contracts;
    using IrishCommon.Common.Exceptions;
    using IrishCommon.Common.User.Enumerations;
   
    public class User : IUser
    {
        private const string DefaultFirstName = "GuestA";
        private const string DefaultLastName = "GuestAA";
        private const string DefaultUserName = "Guest";

        private NotesTextColorType noteTextColor;

        private string firstName;
        private string lastName;
        private string userName;

      //// private char[] invalidSymbolInName = new char[] { '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '.', ',', '+', '?', '\\', '/', '{', '}', ';', ':' };

        public User(string firstName = DefaultUserName, string lastName = DefaultLastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public User(string firstName, string lastName, string userName) : this(firstName, lastName)
        {
            this.userName = userName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!this.ValidateName(value))
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidName);
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!this.ValidateName(value))
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidName);
                }

                this.lastName = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.UserName;
            }

            set
            {
                if (!this.ValidateName(value))
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidName);
                }

                this.UserName = value;
            }
        }

        private bool ValidateName(string name)
        {
            var isValid = true;

            foreach (var letter in name.Trim())
            {
                if (!char.IsDigit(letter) && !char.IsLetter(letter))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public string UserInfo()
        {
            var stb = new StringBuilder();

            stb.AppendLine("User info:");
            stb.AppendLine($"First name: {this.firstName}");
            stb.AppendLine($"Last name: {this.lastName}");
            stb.AppendLine($"User name: {this.userName}");

            return stb.ToString();
        }
    }
}
