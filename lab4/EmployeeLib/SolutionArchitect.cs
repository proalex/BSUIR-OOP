using System;
namespace EmployeeLib
{
    [JobNameAttribute("Solution Architect")]
    [SerializableAttribute]
    public sealed class SolutionArchitect : Architect
    {
        public override string Task { get; set; }

        private SolutionArchitect()
        {
        }

        public SolutionArchitect(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification, task)
        {
        }
    }
}
