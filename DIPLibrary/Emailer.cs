using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLibrary
{
    public class Emailer : IMessageSender
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending email to {person.EmailAddress}");
        }
    }
}
