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
                    throw new InvalidNameException("");
                }

                this.firstName = value;
            }
        }

    }
}
