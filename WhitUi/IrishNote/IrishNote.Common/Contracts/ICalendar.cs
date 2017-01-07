namespace IrishNote.Common.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICalendar
    {
        DateTime CurrentDate { get; }
        List<ITask> tasks { get; set; }
    }
}
