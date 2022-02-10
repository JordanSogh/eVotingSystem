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
        public void Vote(int voteIDC, string CurrentCampaignC, string usernameC, string passwordC) {

            dbHelp.CreateVote(voteIDC,CurrentCampaignC,usernameC,passwordC);

        }

        public Campaign getCurrentCampaign()
        {
            return dbHelp.GetCurrentCampaign(); 
        }
    }
}
