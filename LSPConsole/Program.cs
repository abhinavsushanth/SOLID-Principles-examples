using System;
using LSPLibrary;

namespace LSPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();
            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Sand";
            accountingVP.CalculateRatePerHour(4);

            Employee employee = new CEO();
            employee.FirstName = "Sandy";
            employee.LastName = "Basket";
            employee.AssignManager(accountingVP);
            employee.CalculateRatePerHour(2);

            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour");
            Console.ReadLine();
        }
    }
}
