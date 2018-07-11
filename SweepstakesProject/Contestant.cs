using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        string registrationNumber;
        string name;

        public Contestant()
        {
            firstName = UI.GetUserFirstName();
            lastName = UI.GetUserLastName();
            //ConcatNames();
            emailAddress = UI.GetUserEmail();
            registrationNumber = UI.GetRegistrationNumber();
        }

        //public void ConcatNames()
        //{
        //    name = firstName + " " + lastName;
        //}
    }
}
