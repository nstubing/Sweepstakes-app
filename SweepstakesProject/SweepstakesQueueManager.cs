using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesQueueManager:ISweepstakesManager
    {
        Queue<Sweepstakes> SweepstakesQueue;

        public SweepstakesQueueManager()
        {
            SweepstakesQueue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepstakesQueue.Enqueue(sweepstakes);

        }

        public Sweepstakes GetSweepStakes()
        {
            return SweepstakesQueue.Dequeue();
        }
    }
}
