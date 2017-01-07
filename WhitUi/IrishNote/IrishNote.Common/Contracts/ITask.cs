namespace IrishNote.Common.Contracts
{
    using System;

    public interface ITask
    {
        string NameOfTask { get; set; }
        DateTime DateAndTimeOfTask { get; set; }
    }
}
