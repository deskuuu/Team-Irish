namespace Common.Constants
{
    public sealed class AppConstants
    {
        public const string AppSourceLink = "https://github.com/deskuuu/Team-Irish";
        public const string CustomNotesPath = @"../../Notes/customNotes.txt";

        #region Xml data
        public const string UserLoginDataPath = @"../../Data/users.xml";
        public const string RootTag = "Users";
        public const string NodeTag = "User";
        public const string UsernameTag = "Username";
        public const string PasswordTag = "Password";
        #endregion

        public const string UserLoggedMsg = "You are logged!Welcome ";
        public const string Logged = "Login...";
        public const string WelcomeMsg = "Welcome to the IrishNote app";
    }
}
