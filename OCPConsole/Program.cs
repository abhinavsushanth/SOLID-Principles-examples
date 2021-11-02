using System;
using System.Collections.Generic;
using OCPClassLibrary;

namespace OCPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> persons = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Mog" },
                new ExecutiveModel { FirstName = "Bob", LastName = "Kirk" },
                new ManagerModel { FirstName = "Emily", LastName = "Vance" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            persons.ForEach(person =>
            {
                EmployeeModel employee = person.AccountProcessor.GenerateEmployee(person);
                employees.Add(employee);
            });

            foreach (var worker in employees)
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} {worker.EmailAddress} Is_Manager: {worker.IsManager} Is_Executive: {worker.IsExecutive} ");
            }

            Console.ReadLine();
        }
    }
}
