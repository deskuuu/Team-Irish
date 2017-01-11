namespace Common.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICalendar
    {
        DateTime CurrentDate { get; }
        List<IRootNote> tasks { get; set; }
    }
}
