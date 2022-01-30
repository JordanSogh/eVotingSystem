using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{

    class Campaign
    {
        private int length = 2;
        private string name = "test2";
        private bool isCurrent = true;



        public void CreateNewCampaign()
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.CreateCampaign(name,length,isCurrent);
        }

        public void DeleteCampaign()
        {

        }

        public void getCurrentCampaign()
        {




        }



    }
}
