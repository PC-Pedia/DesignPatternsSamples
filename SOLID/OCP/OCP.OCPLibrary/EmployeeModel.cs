using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.OCPLibrary
{
    public class EmployeeModel
    {
        public object FirstName { get; set; }
        public object LastName { get; set; }
        public object EmailAddress { get; set; }
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
    }
}
