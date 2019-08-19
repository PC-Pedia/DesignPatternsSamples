using OCP.OCPLibrary;
using System;
using System.Collections.Generic;

namespace OCP.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Mehdi", LastName = "Khosravi" },
                new PersonModel{ FirstName = "Ali" , LastName = "Moghaddam" },
                new PersonModel{ FirstName = "Amir" , LastName = "Farahmehr" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Acconts accontProcessor = new Acconts();

            foreach (var person in applicants)
            {
                employees.Add(accontProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
