using System;

namespace EmployeeLib
{
    public abstract class Architect : Employee
    {
        public Architect(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification)
        {
            if (task == null)
                throw new NullReferenceException("task is null");

            Task = task;
        }
    }
}
