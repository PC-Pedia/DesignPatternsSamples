using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.OCPLibrary
{
    public class Acconts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@sample.com";

            return output;
        }
    }
}
