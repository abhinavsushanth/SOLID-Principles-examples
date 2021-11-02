using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculateRatePerHour(int rank)
        {
            decimal baseAmount = 19.50M;
            Salary = baseAmount + (rank * 4);
        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I am reviewing my report's performance");
        }
    }
}
