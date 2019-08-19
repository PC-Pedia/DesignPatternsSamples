using System;

namespace SOLID.SRP.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WellcomeMessage();

            Person user = PersonDataCapture.Capture();

            if (PersonValidator.Validate(user) == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.Create(user);
           
            StandardMessages.EndApplication();
        }
    }
}
