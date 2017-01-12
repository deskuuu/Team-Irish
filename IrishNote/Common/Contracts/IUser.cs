namespace Common.Contracts
{
    public interface IUser
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string Username { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
