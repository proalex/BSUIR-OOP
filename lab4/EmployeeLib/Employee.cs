using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EmployeeLib
{
    [XmlInclude(typeof(Manager))]
    [XmlInclude(typeof(QATester))]
    [XmlInclude(typeof(SoftwareEngineer))]
    [XmlInclude(typeof(SolutionArchitect))]
    [XmlInclude(typeof(SystemArchitect))]
    public abstract class Employee
    { 
        public string Name { get; set; }
        public string SecondName { get; set; }
        public Qualification Qualification { get; set; }
        public virtual string Task { get; set; }

        protected Employee()
        {
        }

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
    }
}
