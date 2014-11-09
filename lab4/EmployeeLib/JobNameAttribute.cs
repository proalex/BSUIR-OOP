using System;

namespace EmployeeLib
{
    public class JobNameAttribute : Attribute
    {
        public readonly string JobName;
        public JobNameAttribute(string jobName)
        {
            JobName = jobName;
        }
    }
}
