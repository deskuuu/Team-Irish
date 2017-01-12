namespace Common.Models
{
    using System;
    using System.Text;

    using Constants;
    using Contracts;
    using Enums;

    public abstract class BaseNote : IBaseNote
    {
        private string title;
        private string text;
        private DateTime createdDate;

        public BaseNote(string title, StatusType status, DateTime createdDate, string text)
        {
            this.Title = title;
            this.Status = status;
            this.createdDate = createdDate;
            this.Text = text;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.Validator(value, ErrorMessagesConstants.NullDataMsg);
                this.title = value;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.Validator(value, ErrorMessagesConstants.NullNoteMsg);
                this.text = value;
            }
        }

        public StatusType Status { get; set; }

        public DateTime CreatedDate => this.createdDate;

        public virtual string GetNote()
        {
            var note = new StringBuilder();

            note.AppendLine($" Title: {this.title}");
            note.AppendLine($"  created on: {this.createdDate}");
            note.AppendLine("Text:");
            note.AppendLine(this.text);

            return note.ToString();
        }

        private void Validator(string value, string errorMsg)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(errorMsg);
            }
        }
    }
}
