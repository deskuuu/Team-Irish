namespace Common.Models
{
    using System;

    public class Note : BaseNote
    {
        public Note(string title, Enums.StatusType status, DateTime createdDate, string text) : base(title, status, createdDate, text)
        {
        }

        public override string GetNote()
        {
            return base.GetNote();
        }
    }
}
