namespace Contracts
{
    public interface IUser
    {
        string FirstName { get; }

        string LastName { get; }

        string Email { get; }

        string Password { get; }

        string GetUserFullName();
    }
}
