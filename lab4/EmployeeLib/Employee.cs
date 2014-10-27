using System;

namespace EmployeeLib
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        public string SecondName { get; private set; }
        public Qualification Qualification { get; private set; }
        public virtual string Task { get; protected set; }
        public virtual string Job { get; protected set; }

        protected Employee(string name, string secondName, Qualification qualification)
        {
            if (name == null)
                throw new NullReferenceException("name is null");

            if (secondName == null)
                throw new NullReferenceException("secondName is null");

            Name = name;
            SecondName = secondName;
            Qualification = qualification;
        }

        public override string ToString()
        {
            return Name + " " + SecondName + " " + Qualification + " " + Job;
        }
    }
}
