namespace Models
{
    using System;
    using System.Text;

    using Contracts;
    using System.Text.RegularExpressions;

    public class User : IUser
    {
        private const int DefaultMaxLength = 50;
        private const int MaxUserCapacity = 100;
        public const string DefaultFirstName = "Guest";

        private int ID { get; set; }
        public string Password { get; }

        /// <summary>
        /// User fields.
        /// </summary>
        private string firstName;
        private string lastName;
        private string userName;
        private string email;

        /// <summary>
        /// Empty constructor for create user withought user datas.
        /// </summary>
        public User()
        {
            this.firstName = DefaultFirstName;
            this.ID = GenerateRandomID();
        }

        /// <summary>
        /// User base constructor with all parameters.
        /// </summary>
        public User(string lastName, string userName, string email, string password, string firstName = DefaultFirstName)
        {
            this.LastName = lastName;
            this.Username = userName;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                ValidateName(value);

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
                ValidateName(value);

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
                ValidateName(value);

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

                bool isEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                if (isEmail)
                {
                    this.email = value;
                }
                else
                {
                    throw new FormatException("Invalid mail.");
                }
            }
        }

        public string GetUserFullName()
        {
            if (this.lastName != null)
            {
                return $"{this.firstName} {this.lastName}";
            }
            else
            {
                return this.firstName;
            }
        }

        public override string ToString()
        {
            var stb = new StringBuilder(DefaultMaxLength);

            stb.AppendLine($"ID: {GenerateRandomID()}");
            stb.AppendLine($"User: {this.userName}");
            stb.AppendLine($"Name: {this.GetUserFullName()}");
            stb.AppendLine($"Email: {this.email}");
            stb.AppendLine($"Password: {this.Password}");

            return stb.ToString();
        }

        private int GenerateRandomID()
        {
            var randomGenerator = new Random();
            var id = randomGenerator.Next(MaxUserCapacity);

            return id;
        }

        private void ValidateName(string name)
        {
            if (String.IsNullOrEmpty(name.Trim()))
            {
                throw new ArgumentException("Invalid name.");
            }
            else
            {
                foreach (var letter in name)
                {
                    if (!char.IsLetter(letter))
                    {
                        throw new ArgumentException("Invalid name.");
                    }
                }
            }
        }
    }
}
