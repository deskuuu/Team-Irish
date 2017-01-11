namespace IrishNote.Common
{
    using System;

    using Enumerations;
    using System.Text;

    public class Task
    {
        private string taskName;
        private Types taskType;
        private Priority taskPriority;
        private DateTime taskDeadline;
        private string taskInformation;

        public Task(string taskName, Types taskType,Priority taskPriority,DateTime taskDeadline,string taskInformation)
        {
            this.taskName = taskName;
            this.taskType = taskType;
            this.taskPriority = taskPriority;
            this.taskDeadline = taskDeadline;
            this.taskInformation = taskInformation;
        }

        public string TaskName
        {
            get
            {
                return this.taskName;
            }
            set
            {
                 //TODO Validation
                this.taskName = value;
            }
        }
        public Types TaskType
        {
            get
            {
                return this.taskType;
            }
            set
            {
                //TODO Validation
                this.taskType = value;
            }
        }
        public Priority TaskPriority
        {
            get
            {
                return this.taskPriority;
            }
            set
            {
                //TODO Validation
                this.taskPriority = value;
            }
        }
        public DateTime TaskDeadline
        {
            get
            {
                return this.taskDeadline;
            }
            set
            {
                //TODO: Validation
                this.taskDeadline = value;
            }
        }
        public string TaskInformation
        {
            get
            {
               return this.taskInformation;
            }
            set
            {
                //TODO Validation
                this.taskInformation = value;
            }
        }

        public override string ToString()
        {
            var information = new StringBuilder();
            information.Append(this.taskName);
            information.AppendLine();
            information.AppendFormat("Priority: {0}, Type {1}, Deadline {2}",
                        this.taskPriority, this.taskType, this.taskDeadline);
            information.AppendLine();
            information.Append(this.taskInformation);
            return information.ToString();
        }

    }
}
