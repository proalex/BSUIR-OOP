namespace EmployeeLib
{
    public sealed class SolutionArchitect : Architect
    {
        public override string Task { get; protected set; }
        public override string Job
        {
            get { return "Solution Architect"; }
            protected set { }
        }

        public SolutionArchitect(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification, task)
        {
        }
    }
}
