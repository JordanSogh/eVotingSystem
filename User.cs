using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
        public abstract class User
        {
        public Campaign getCurrentCampaign()
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            return dbHelp.GetCurrentCampaign();
        }

    }
}
