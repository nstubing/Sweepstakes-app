using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace SweepstakesProject
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakeStorage;
        int numberOfSweepstakes;

        public MarketingFirm(ISweepstakesManager style)
        {
            this.sweepstakeStorage = style;
            InputSweepstakes();
            UpdateSweepstakes();
        }

        public void Add(Sweepstakes sweepstakes)
        {
            sweepstakeStorage.InsertSweepstakes(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakeStorage.GetSweepStakes();
        }

        public void InputSweepstakes()
        {
            int currentNumber = 1;
            numberOfSweepstakes = UI.InputSweepstakesAmount();
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                string sweepName = UI.GetSweepName(currentNumber);
                Sweepstakes thisSweep = new Sweepstakes(sweepName);
                Add(thisSweep);
                currentNumber++;
            }
        }

        public void UpdateSweepstakes()
        {
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes currentSweep = GetSweepstakes();
                bool updateSweep = UI.UpdateCurrentSweepBool(currentSweep);
                if (updateSweep)
                {
                    int newContestants = UI.NewContestants(currentSweep);
                    for (int j = 0; j < newContestants; j++)
                    {
                        Contestant newContestant = new Contestant();
                        currentSweep.RegisterContestant(newContestant);
                    }
                    PickWinners(currentSweep);
                }
            }
        }

        public void PickWinners(Sweepstakes currentSweep)
        {
            bool pickwinner = UI.AskPickWinner(currentSweep);
            if (pickwinner)
            {
                Contestant winner = currentSweep.PickWinner();
                currentSweep.PrintContestantInfo(winner);
                Console.ReadLine();
                //AlertResults(currentSweep, winner);
                Console.Clear();

            }
        }





        public void AlertResults(Sweepstakes currentSweep, Contestant winner)
        {
            string myIp = IPAddress.Loopback.ToString();
            SmtpClient client = new SmtpClient(myIp);
            MailAddress from = new MailAddress("marketingfirm@gmail.com");
            foreach(KeyValuePair<int,Contestant>contestant in currentSweep.contestantDictionary)
            {
                MailAddress to = new MailAddress(contestant.Value.emailAddress);
                MailMessage mailMessage = new MailMessage(from, to);
                mailMessage.Subject = "Sweepstakes Results!";
                if (contestant.Key == currentSweep.winnerKeyValue)
                {
                    mailMessage.Body = "You have won the Sweepstakes " + currentSweep.name + "!";
                }
                else
                {
                    mailMessage.Body = "You have lost the sweepstakes " + currentSweep.name + ".";
                }
                try
                {
                    client.Send(mailMessage);
                }
                catch(Exception)
                {
                    Console.WriteLine("message failed to send to "+contestant.Value.name+".");
                }


            }
        }
    }
}
