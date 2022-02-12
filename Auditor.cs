using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Auditor : User
    {
        DatabaseHelper dbHelp = new DatabaseHelper();


        public List<string> GetCompletedCampaignVotes(string campaign)
        {
            return dbHelp.GetCompletedCampaignVotes(campaign);
        }
        public List<string> GetAllCampaigns()
        {
            return dbHelp.GetAllCampaigns();
        }

        public List<Vote> GetAllVotes(string campaign)
        {
            return dbHelp.GetAllVotes(campaign);
        }

        public int CountAllVotes(string campaign)
        {
            int allVotes = dbHelp.GetAllVotes(campaign).Count();
            return allVotes;
        }

        public string CalculateWinner(string campaign)
        {
            string winner = "";

            List<Vote> allVotes = dbHelp.GetAllVotes(campaign);
            List<string> allVotesDescription = new List<string>();

            foreach (Vote v in allVotes)
            {
                allVotesDescription.Add(v.BallotDescription);
            }
            if (allVotesDescription.Count() > 0 )
            {
              
                winner = (from x in allVotesDescription group x by x into grpvotes orderby grpvotes.Count() descending select grpvotes.Key).First();

            }
            return winner;

        }

        public List<string> CalculateOrder(string campaign)
        {
            List<string> orderList = new List<string>();

            List<Vote> allVotes = dbHelp.GetAllVotes(campaign);
            List<string> allVotesDescription = new List<string>();

            foreach (Vote v in allVotes)
            {
                allVotesDescription.Add(v.BallotDescription);
            }
            if (allVotesDescription.Count() > 0)
            {
                foreach (var item in allVotesDescription.GroupBy(x => x)
                        .Select(group => new {
                            Option = group.Key,
                            Count = group.Count()
                        })
                        .OrderBy(x => x.Option))
                {
                    orderList.Add( item.Option +" - "+ item.Count + " Votes");
                }

            }
            return orderList;

        }
    }

}
