namespace Common.Contracts
{
    using System;
    using System.Collections;

    public interface IRootNote : IList
    {
        string Title { get; set; }

        void GetAll();
    }

    public interface ITask : IRootNote
    {
        DateTime DateAndTimeOfTask { get; set; }

        Status StatusOfNote { get; set; }

    }

    public interface IEvent : ITask
    {
        string Location { get; set; }
    }
}
