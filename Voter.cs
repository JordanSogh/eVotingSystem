using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Voter
    { 

        DatabaseHelper dbHelp = new DatabaseHelper();
        public void Vote() {
        
        }

        public Campaign getCurrentCampaign()
        {
            return dbHelp.GetCurrentCampaign(); 
        }
    }
}
