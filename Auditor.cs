using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Auditor : User
    {
        DatabaseHelper _dbHelp = new DatabaseHelper();

        public List<string> GetCompletedCampaignVotes(string campaign)
        {
            return _dbHelp.GetCompletedCampaignVotes(campaign);
        }
        public List<string> GetAllCampaigns()
        {
            return _dbHelp.GetAllCampaigns();
        }

        public List<Vote> GetAllVotes(string campaign)
        {
            return _dbHelp.GetAllVotes(campaign);
        }

        public int CountAllVotes(string campaign)
        {  
            int allVotes = _dbHelp.GetAllVotes(campaign).Count();
            return allVotes;
        }
        public string CalculateWinner(string campaign)
        {
            // Retrieves the Votes of a Campaign then Calculates the winner by grouping and sorting in order. Returns the winner.
            string winner = "";

            List<Vote> allVotes = _dbHelp.GetAllVotes(campaign);
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
            // Retrieves the Votes of a Campaign and then sorts them in order. Returns a list with the ordered options and their votes.
            List<string> orderList = new List<string>();

            List<Vote> allVotes = _dbHelp.GetAllVotes(campaign);
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
