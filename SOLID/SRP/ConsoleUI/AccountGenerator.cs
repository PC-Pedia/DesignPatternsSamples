using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.ConsoleUI
{
    public class AccountGenerator
    {
        public static void Create(Person user)
        {
            // Create a username for person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
