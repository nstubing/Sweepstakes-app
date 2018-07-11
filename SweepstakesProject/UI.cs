using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UI
    {

        public static string GetUserFirstName()
        {
            Console.WriteLine("What is your first Name?");
            return Console.ReadLine();
        }
        public static string GetUserLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }
        public static string GetUserEmail()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }

        public static string GetRegistrationNumber()
        {
            Console.WriteLine("Input a registration number for security purposes.");
            return Console.ReadLine().ToString();
        }
    }
}
