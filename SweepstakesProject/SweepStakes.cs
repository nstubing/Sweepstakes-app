using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        public string name;
        public Dictionary<int, Contestant> contestantDictionary;
        public int contestants = 0;
        public int winnerKeyValue;
        Random rnd= new Random();


        public Sweepstakes(string name)
        {
            contestantDictionary = new Dictionary<int, Contestant>();
            Random rnd = new Random();
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantDictionary.Add(contestants, contestant);
            contestants++;

        }

        public Contestant PickWinner()
        {
            int winningKey = rnd.Next(0, contestants);
            foreach(KeyValuePair<int, Contestant> contestant in contestantDictionary)
            {
                if (contestant.Key==winningKey)
                {
                    winnerKeyValue = winningKey;
                    return contestant.Value;
                }
            }
            return null;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("THE WINNER IS...");
            Console.WriteLine("Name: "+contestant.name);
            Console.WriteLine("Email Address: "+ contestant.emailAddress);
            Console.WriteLine("Registration Number: "+contestant.registrationNumber);
        }


    }
}
