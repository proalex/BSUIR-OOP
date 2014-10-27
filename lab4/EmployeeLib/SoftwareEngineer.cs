using System;

namespace EmployeeLib
{
    public sealed class SoftwareEngineer : Employee
    {
        public override string Task { get; protected set; }
        public override string Job
        {
            get { return "Software Engineer"; }
            protected set { }
        }

        public SoftwareEngineer(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification)
        {
            if (task == null)
                throw new NullReferenceException("task is null");

            Task = task;
        }
    }
}
