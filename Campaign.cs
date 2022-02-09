using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{

    public class Campaign
    {
        private int length = 2;
        private string name = "test2";
        private bool isCurrent = true;

        DatabaseHelper dbHelp = new DatabaseHelper();

        public int Length { get => length; set => length = value; }
        public string Name { get => name; set => name = value; }
        public bool IsCurrent { get => isCurrent; set => isCurrent = value; }

        public Campaign(string nameC, int lengthC, bool isCurrentC)
        {
            this.name = nameC;
            this.length = lengthC;
            this.isCurrent = isCurrentC;

        }

        public void CreateNewCampaign()
        {
            dbHelp.CreateCampaign(name,length,isCurrent);
        }

        public void DeleteCampaign()
        {
            dbHelp.DeleteCampaign(name);
        }

        public List<string> GetCampaignVoteOptionsCampaign()
        {
            List<string> voteOptions = dbHelp.GetCurrentCampaignVoteOptions(name);
            return voteOptions;
        }


    }
}
