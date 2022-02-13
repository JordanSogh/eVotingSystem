using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Admin:User
    {
        DatabaseHelper dbHelp = new DatabaseHelper();
        public bool CreateNewCampaign(string name, int length)
        {
           return dbHelp.CreateCampaign(name, length);
        }

        public bool CreateNewCampaignOptions(List<string> optionsList, string campaign)
        {
            return dbHelp.CreateCampaignOptions(optionsList, campaign);
        }
        public bool DeleteUser(string userName)
        {
            return dbHelp.DeleteUser(userName);
        }

        public bool CreateUser(string username, string password, string role) {
            return dbHelp.AddUser( username,password,role);
        }

        
    }
}
