using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP5._0
{
    internal class UserNameGenerator
    {
        internal static void NameGenerator(Person person)
        {
            Console.WriteLine($"Your username is {person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}
