namespace Common
{
    using Exceptions;
    using HelperMethods;

    public class User
    {
        /// <summary>
        /// Automatic property for user age storage.
        /// </summary>
        private int id { get; }

        /// <summary>
        /// 
        /// </summary>
        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private string password;

        /// <summary>
        /// User base constructor with all parameters.
        /// </summary>
        public User(string firstName, string lastName, string userName, string email, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = userName;
            this.Email = email;
        }


        /// <summary>
        /// New syntax getter.
        /// </summary>
        public int ID => this.id;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set 
            {
                if (!Validate.ValidateNameField(value))
                {
                    throw new InvalidNameException("The first name is not valid, please try again!");
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
                if(!Validate.ValidateNameField(value))
                {
                    throw new InvalidNameException("The last name is not valid, please try again!");
                }

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
                if(!Validate.ValidateUsernameField(value))
                {
                    throw new InvalidUsernameException("The username is not valid, please try again!");
                }

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
                if(!Validate.ValidateEmailField(value))
                {
                    throw new InvalidEmailException("The email is not valid, please try again!");
                }

                this.email = value;
            }
        }

    }
}
