using System;

namespace EmployeeLib
{
    [JobNameAttribute("Manager")]
    [SerializableAttribute]
    public sealed class Manager : Employee
    {
        public override string Task { get; set; }

        private Manager()
        {
        }

        public Manager(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification)
        {
            if (task == null)
                throw new NullReferenceException("task is null");

            Task = task;
        }
    }
}
