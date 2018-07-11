using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm
    {
       // List<ISweepstakesManager> sweepstakes;
        ISweepstakesManager sweepstakeStorage;

        public MarketingFirm(ISweepstakesManager style)
        {
            this.sweepstakeStorage = style;
        }

        public void Add(Sweepstakes sweepstakes)
        {
            sweepstakeStorage.InsertSweepstakes(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakeStorage.GetSweepStakes();
        }
        
    }
}
