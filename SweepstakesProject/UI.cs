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
            Console.WriteLine("What is your contestants first Name?");
            return Console.ReadLine();
        }
        public static string GetUserLastName()
        {
            Console.WriteLine("What is your contestants last name?");
            return Console.ReadLine();
        }
        public static string GetUserEmail()
        {
            Console.WriteLine("What is your contestants email address?");
            return Console.ReadLine();
        }

        public static string GetRegistrationNumber()
        {
            Console.WriteLine("Input a registration number for security purposes.");
            return Console.ReadLine().ToString();
        }

        public static ISweepstakesManager GetMarketingFirmStorageStyle()
        {
            Console.WriteLine("Would you like to use a stack or Queue for your sweepstakes");
            string style = Console.ReadLine().ToLower().Trim();
            if (style == "queue")
            {
                SweepstakesQueueManager myStyle = new SweepstakesQueueManager();
                return myStyle;
            }
            else if (style == "stack")
            {
                SweepstakesStackManager myStackStyle = new SweepstakesStackManager();
                return myStackStyle;
            }
            else
            {
                Console.WriteLine("please enter stack or queue.");
                GetMarketingFirmStorageStyle();
                SweepstakesStackManager myStackStyle = new SweepstakesStackManager();
                return myStackStyle;
            }
        }

        public static int InputSweepstakesAmount()
        {
            Console.WriteLine("how many sweepstakes would you like to add?");
            return Int32.Parse(Console.ReadLine());
        }

        public static string GetSweepName(int number)
        {

            Console.WriteLine("What would you like the name of the sweepstakes number "+number+" to be?");
            return Console.ReadLine();
        }

        public static bool UpdateCurrentSweepBool(Sweepstakes currentSweep)
        {
            Console.WriteLine("Would you like to update the Sweepstakes named " +currentSweep.name+" with contestants or pick a winner? Type 'yes' or 'no'");
            string answer = Console.ReadLine().ToLower().Trim();
            bool update=false;
            switch (answer)
            {
                case "yes":
                    update = true;
                    break;
                case "no":
                    update = false;
                    break;
                default:
                    Console.WriteLine("Please input 'yes' or 'no'");
                    UpdateCurrentSweepBool(currentSweep);
                    break;
            }
            return update;
        }

        public static int NewContestants(Sweepstakes currentSweep)
        {
            Console.WriteLine("How many contestants would you like to add to the Sweepstakes named "+currentSweep.name+"?");
            int newContestants = Int32.Parse(Console.ReadLine());
            return newContestants;
        }

        public static bool AskPickWinner(Sweepstakes currentSweep)
        {
            Console.Clear();
            Console.WriteLine("Would you like to pick a winner from the Sweepstakes named " + currentSweep.name + "  Input 'yes' or 'no'");
            string answer = Console.ReadLine().ToLower().Trim();
            bool pickWinner = false;
            switch (answer)
            {
                case "yes":
                    pickWinner = true;
                    break;
                case "no":
                    pickWinner = false;
                    break;
                default:
                    Console.WriteLine("Please input 'yes' or 'no'");
                    AskPickWinner(currentSweep);
                    break;
            }
            return pickWinner;
        }
    }
}
