using OCP.OCPLibrary;
using System;
using System.Collections.Generic;

namespace OCP.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel{ FirstName = "Mehdi", LastName = "Khosravi" },
                new ManagerModel{ FirstName = "Ali" , LastName = "Moghaddam" },
                new ExecutiveModel{ FirstName = "Amir" , LastName = "Farahmehr" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accontProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} " +
                    $"IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
