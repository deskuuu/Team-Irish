namespace Common.Models
{
    using Contracts;
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
