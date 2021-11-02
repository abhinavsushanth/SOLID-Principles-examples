namespace OCPClassLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel GenerateEmployee(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{output.FirstName.Substring(0, 1)}.{output.LastName}@acme.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}