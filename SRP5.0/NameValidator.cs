using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP5._0
{
    internal class NameValidator
    {
        internal static bool IsValidName(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.NameErrorMessage("first");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.NameErrorMessage("last");
                return false;
            }
            return true;
        }
    }
}
