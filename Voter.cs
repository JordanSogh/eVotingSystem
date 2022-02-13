using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Voter: User
    {

        DatabaseHelper dbHelp = new DatabaseHelper();
        public bool Vote(int voteID, string CurrentCampaign, string username, string password, string ballotDesc) {

            return dbHelp.CreateVote(voteID, CurrentCampaign, username, password, ballotDesc);
        }

        public bool hasAlreadyVoted(string username)
        {
            return dbHelp.HasAlreadyVoted(username);
        }

        public List<string> GetCampaignVoteOptionsCampaign(string campaign)
        {
            List<string> voteOptions = dbHelp.GetCurrentCampaignVoteOptions(campaign);
            return voteOptions;
        }
    }
}
