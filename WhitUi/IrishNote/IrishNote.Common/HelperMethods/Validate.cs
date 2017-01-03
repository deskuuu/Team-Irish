namespace Common.HelperMethods
{
    using System;
    using System.Net.Mail;

    public static class Validate
    {
        private const int MinSymbolName = 5;
        private const int MinSymbolUsername = 6;

        public static bool ValidateNameField(string name)
        {
            name.Trim();

            var isValidField = true;

            if (string.IsNullOrEmpty(name) || name.Length < MinSymbolName)
            {
                isValidField = false;
            }

            return isValidField;
        }

        public static bool ValidateUsernameField(string username)
        {
            username.Trim();

            var isValidField = true;

            if(string.IsNullOrEmpty(username) || username.Length < MinSymbolUsername)
            {
                isValidField = false;
            }

            return isValidField;
        }

        public static bool ValidateEmailField(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
