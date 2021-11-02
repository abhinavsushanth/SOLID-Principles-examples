using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP5._0
{
    internal class UserInputPerson
    {
        internal static Person PersonUserInput()
        {
            Person person = new Person();
            StandardMessages.UserInputMessage("first");
            person.FirstName = Console.ReadLine();
            StandardMessages.UserInputMessage("last");
            person.LastName = Console.ReadLine();
            return person;
        }
    }
}
