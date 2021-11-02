using System;

namespace SRP5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person person = UserInputPerson.PersonUserInput();

            bool isValidName = NameValidator.IsValidName(person);

            if (!isValidName)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Creating User Name
            UserNameGenerator.NameGenerator(person);
            StandardMessages.EndApplication();
        }
    }
}
