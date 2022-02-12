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
        public void Vote(int voteID, string CurrentCampaign, string username, string password, string ballotDesc) {

            dbHelp.CreateVote(voteID,CurrentCampaign,username,password,ballotDesc);

        }

        public bool hasAlreadyVoted(string username)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            return dbHelp.HasAlreadyVoted(username);
        }
    }
}
