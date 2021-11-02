using System;
using LSPLibrary;

namespace LSPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();
            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Sand";
            accountingVP.CalculateRatePerHour(4);

            IManaged employee = new Employee();
            employee.FirstName = "Sandy";
            employee.LastName = "Basket";
            //employee.AssignManager(accountingVP);
            employee.CalculateRatePerHour(2);

            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour");
            Console.ReadLine();
        }
    }
}
