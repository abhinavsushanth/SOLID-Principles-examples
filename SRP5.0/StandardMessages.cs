using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP5._0
{
    internal class StandardMessages
    {
        internal static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to this lame app");
        }

        internal static void EndApplication()
        {
            Console.ReadLine();
        }

        internal static void UserInputMessage(string nameType)
        {
            Console.WriteLine($"What is your {nameType} name ");
        }

        internal static void NameErrorMessage(string nameType)
        {
            Console.WriteLine($"You have provided an empty {nameType} name");
        }
    }
}
