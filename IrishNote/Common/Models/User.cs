namespace Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    using Constants;
    using Contracts;

    public class User : IUser
    {
        private DataContainer<IEvent> eventsList;
        private DataContainer<INote> notesList;
        private DataContainer<ITask> tasksList;

        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private string password;

        public User()
        {
            this.eventsList = new DataContainer<IEvent>();
            this.notesList = new DataContainer<INote>();
            this.tasksList = new DataContainer<ITask>();
        }

        public User(string firstName, string lastName, string userName, string email, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = userName;
            this.Email = email;
            this.Password = password;
        }

        public DataContainer<IEvent> EventsList => this.eventsList;

        public DataContainer<INote> NotesList => this.notesList;

        public DataContainer<ITask> TasksList => this.tasksList;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateName(value);

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
                this.ValidateName(value);

                this.lastName = value;
            }
        }

        public string Username
        {
            get
            {
                return this.userName;
            }

            set
            {
                this.ValidateName(value);

                this.userName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                bool isValidEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                if (isValidEmail)
                {
                    this.email = value;
                }
                else
                {
                    throw new FormatException(ErrorMessagesConstants.InvalidMeilMsg);
                }
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException(ErrorMessagesConstants.InvalidPasswordMsg);
                }

                this.password = value;
            }
        }

        public override string ToString()
        {
            var stb = new StringBuilder();

            stb.AppendLine($"User: {this.userName}");
            stb.AppendLine($"Name: {this.firstName} {this.lastName}");
            stb.AppendLine($"Email: {this.email}");
            stb.AppendLine($"Password: {this.Password}");

            return stb.ToString();
        }

        private void ValidateName(string name)
        {
            var hasError = false;

            if (string.IsNullOrEmpty(name.Trim()))
            {
                hasError = true;
            }
            else
            {
                foreach (var letter in name)
                {
                    if (!char.IsLetter(letter))
                    {
                        hasError = true;
                    }
                }
            }

            if (hasError)
            {
                throw new ArgumentException(ErrorMessagesConstants.InvalidNameFieldMsg);
            }
        }
    }
}
