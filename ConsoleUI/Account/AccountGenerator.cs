namespace ConsoleUI.Account
{
    internal class AccountGenerator
    {
        public static void CreateAccount(Person.Person user)
        {

            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
