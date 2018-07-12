using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string registrationNumber;
        public string name;

        public Contestant()
        {
            Console.Clear();
            Console.WriteLine("NEW CONTESTANT:");
            firstName = UI.GetUserFirstName();
            lastName = UI.GetUserLastName();
            //ConcatNames();
            emailAddress = UI.GetUserEmail();
            registrationNumber = UI.GetRegistrationNumber();
            name = firstName + " " + lastName;
        }

        //public void ConcatNames()
        //{
        //    name = firstName + " " + lastName;
        //}
    }
}
