using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Voter: User
    {

        DatabaseHelper _dbHelp = new DatabaseHelper();
        public bool Vote(int voteID, string CurrentCampaign, string username, string password, string ballotDesc) {

            return _dbHelp.CreateVote(voteID, CurrentCampaign, username, password, ballotDesc);
        }

        public bool HasAlreadyVoted(string username)
        {
            return _dbHelp.HasAlreadyVoted(username);
        }

        public List<string> GetCampaignVoteOptionsCampaign(string campaign)
        {
            List<string> voteOptions = _dbHelp.GetCurrentCampaignVoteOptions(campaign);
            return voteOptions;
        }
    }
}
