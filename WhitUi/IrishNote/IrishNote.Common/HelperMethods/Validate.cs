namespace Common.HelperMethods
{
    public static class Validate
    {
        private const int MinSymbolName = 5;
        private const int MinSymbolUsername = 6;

        public static bool ValidateNameField(string value)
        {
            value.Trim();

            var isValidField = true;

            if (string.IsNullOrEmpty(value) || value.Length < MinSymbolName)
            {
                isValidField = false;
            }

            return isValidField;
        }

        public static bool ValidateUsernameField(string value)
        {
            value.Trim();

            var isValidField = true;

            if(string.IsNullOrEmpty(value) || value.Length < MinSymbolUsername)
            {
                isValidField = false;
            }

            return isValidField;
        }
    }
}
