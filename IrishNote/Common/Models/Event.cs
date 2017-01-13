namespace Common.Models
{
    using Contracts;
    using Enums;
    using System;

    public abstract class Event : BaseNote, IEvent
    {
        public Event(string title, StatusType status, DateTime createdDate, string text) : base(title, status, createdDate, text)
        {
        }

        public override string GetNote()
        {
            return base.GetNote();
        }

    }
}
