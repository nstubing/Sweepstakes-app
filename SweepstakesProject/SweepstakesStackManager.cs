using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager:ISweepstakesManager
    {
        Stack<Sweepstakes> SweepstakesQueue;

        public SweepstakesStackManager()
        {
            SweepstakesQueue = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepstakesQueue.Push(sweepstakes);

        }

        public Sweepstakes GetSweepStakes()
        {
            return SweepstakesQueue.Pop();
        }
    }
}
