namespace Common.Constants
{
    public sealed class ErrorMessagesConstants
    {
        public const string InvalidHyperlink = "Invalid provided source link!";

        #region UserFields
        public const string InvalidMeilMsg = "Invalid e-meil format!";
        public const string InvalidPasswordMsg = "Password must be greather than 4 symbols!";
        public const string InvalidNameFieldMsg = "Invalid name!";
        #endregion

        #region Message box captions
        public const string MsgBoxCaptionAboutClick = "Hyperlink exception";
        public const string MsgBoxCaptionUser = "User data exeption";
        public const string MsgBoxLoginDataCaption = "Invalid login data";
        public const string MsgBoxSaveCaption = "Custom note";
        #endregion

        public const string UserExcistMsg = "Username was registerd.Try with another one!";
        public const string InvalidLoginDataMsg = "Invalid username or password!";
        public const string NullDataMsg = "Please input data!";
        public const string NullNoteMsg = "Note cannot be empty!";

        public const string SaveWithougthUser = "To save your custom note, please log on or make a new registration!";
    }
}
