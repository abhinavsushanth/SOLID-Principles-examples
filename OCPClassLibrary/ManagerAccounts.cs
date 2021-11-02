using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPClassLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel GenerateEmployee(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{output.FirstName.Substring(0, 1)}.{output.LastName}@acme.com";

            output.IsManager = true;

            return output;
        }
    }
}
