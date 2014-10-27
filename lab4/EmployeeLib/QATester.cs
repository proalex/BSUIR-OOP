using System;

namespace EmployeeLib
{
    public sealed class QATester : Employee
    {
        public override string Task { get; protected set; }
        public override string Job
        {
            get { return "Quality Assurance Tester"; }
            protected set { }
        }

        public QATester(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification)
        {
            if (task == null)
                throw new NullReferenceException("task is null");

            Task = task;
        }
    }
}
