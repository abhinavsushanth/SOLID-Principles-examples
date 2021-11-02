using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class CEO : Employee
    {
        public override void CalculateRatePerHour(int rank)
        {
            decimal baseAmount = 100.50M;
            Salary = baseAmount * rank;
        }
        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I am reviewing my report's performance");
        }
        public void FireSomeone()
        {
            Console.WriteLine("Firing someone");
        }
    }
}
