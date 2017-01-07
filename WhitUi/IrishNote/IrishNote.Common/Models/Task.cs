namespace IrishNote.Common.Models
{
    using System;
    using System.Globalization;
    using IrishNote.Common.Contracts;

    public class Task : ITask
    {
        private DateTime dateAndTimeOfTask;
        private string nameOfTask;
        private const int minLengthOfName = 5;

        public DateTime DateAndTimeOfTask
        {
            get
            {
                return dateAndTimeOfTask;
            }

            set
            {
                dateAndTimeOfTask = Convert.ToDateTime(value);
            }
        }

        public string NameOfTask
        {
            get
            {
                return nameOfTask;
            }

            set
            {
                if(value.Length < minLengthOfName)
                {
                    throw new ArgumentException("The length of the name is bellow the minumum length required!");
                }
                nameOfTask = value;
            }
        }
    }
}
