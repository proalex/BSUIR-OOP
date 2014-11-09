using System;

namespace EmployeeLib
{
    [JobNameAttribute("Software Engineer")]
    [SerializableAttribute]
    public sealed class SoftwareEngineer : Employee
    {
        public override string Task { get; set; }

        private SoftwareEngineer()
        {
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
