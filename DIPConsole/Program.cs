using System;
using DIPLibrary;

namespace DIPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Patrick";
            owner.LastName = "Star";
            owner.EmailAddress = "patrickstar@gmail.com";
            owner.PhoneNumber = "222-1111";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(2);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
