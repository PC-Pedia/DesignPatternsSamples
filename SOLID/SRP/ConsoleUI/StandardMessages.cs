using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.ConsoleUI
{
    public class StandardMessages
    {
        public static void WellcomeMessage()
        {
            Console.WriteLine("Wellcome to my application!");
        }

        public static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }
        
    }
}
