using System;

namespace EmployeeLib
{
    [JobNameAttribute("Quality Assurance Tester")]
    [SerializableAttribute]
    public sealed class QATester : Employee
    {
        public override string Task { get; set; }

        private QATester()
        {
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
