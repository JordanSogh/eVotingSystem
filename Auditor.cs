using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Auditor
    {
        DatabaseHelper dbHelp = new DatabaseHelper();
        public Campaign getCurrentCampaign()
        {
            return dbHelp.GetCurrentCampaign();
        }
        public void DeleteCampaign(string nameC)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.DeleteCampaign(nameC);
        }



    }

}
