using Common.Models;

namespace Common.Contracts
{
    public interface IUser
    {
        DataContainer<IEvent> EventsList { get; }

        DataContainer<INote> NotesList { get; }

        DataContainer<ITask> TasksList { get; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Username { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
