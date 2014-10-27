namespace EmployeeLib
{
    public sealed class SystemArchitect : Architect
    {
        public override string Task { get; protected set; }
        public override string Job
        {
            get { return "System Architect"; }
            protected set { }
        }

        public SystemArchitect(string name, string secondName, Qualification qualification, string task)
            : base(name, secondName, qualification, task)
        {
        }
    }
}
