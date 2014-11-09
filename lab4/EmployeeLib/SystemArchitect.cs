using System;
namespace EmployeeLib
{
    [JobNameAttribute("System Architect")]
    [SerializableAttribute]
    public sealed class SystemArchitect : Architect
    {
        public override string Task { get; set; }

        private SystemArchitect()
        {
        }

        public SystemArchitect(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification, task)
        {
        }
    }
}
