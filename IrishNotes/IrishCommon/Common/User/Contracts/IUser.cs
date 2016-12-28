namespace IrishNotes.Common.User.Contracts
{
    public interface IUser
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string UserName { get; set; }

        string UserInfo();
    }
}
