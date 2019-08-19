using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.OCPLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@manager.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
