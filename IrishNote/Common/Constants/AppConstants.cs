namespace Common.Constants
{
    sealed public class AppConstants
    {
        public const string AppSourceLink = "https://github.com/deskuuu/Team-Irish";

        #region Xml data
        public const string UserLoginDataPath = @"../../Data/users.xml";
        public const string RootTag = "Users";
        public const string NodeTag = "User";
        public const string usernameTag = "Username";
        public const string passwordTag = "Password";
        #endregion

        public const string UserLogged = "You are logged.Welcome ";
        public const string Logged = "Login...";
        public const string WelcomeBack = "Welcome back to the IrishNotes app";
    }
}
