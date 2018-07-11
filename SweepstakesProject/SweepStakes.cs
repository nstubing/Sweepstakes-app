using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepStakes
    {
        public string name;
        public Dictionary<int, Contestant> contestantDictionary;
        int contestants = 0;


        public SweepStakes(string name)
        {
            Random rnd = new Random();
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantDictionary.Add(contestants, contestant);
            contestants++;

        }

        public string PickWinner(Random rnd)
        {
            int winner = rnd.Next(0, contestants);
        }


    }
}
