using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
        public abstract class User
        {
        DatabaseHelper dbHelp = new DatabaseHelper();
        public Campaign getCurrentCampaign()
        {
            return dbHelp.GetCurrentCampaign();
        }

    }
}
