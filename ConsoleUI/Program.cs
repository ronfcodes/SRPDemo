using ConsoleUI.Account;
using ConsoleUI.Messages;
using ConsoleUI.Person;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            Person.Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            //Create a username for the person
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}