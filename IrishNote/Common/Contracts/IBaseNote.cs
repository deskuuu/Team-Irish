namespace Common.Contracts
{
    using System;

    using Enums;

    public interface IBaseNote
    {
        string Title { get; set; }

        StatusType Status { get; set; }

        DateTime CreatedDate { get; }

        string Text { get; set; }
    }
}
