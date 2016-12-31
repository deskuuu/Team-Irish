namespace IrishNotes.Common.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string UserName { get; set; }

        void SaveUserData();

        string GetUserData { get; }

        void SetPriorityNotes();

        void GetPriorityNotes();

        string GetBonusLuck();
    }
}
