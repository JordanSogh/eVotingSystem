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
        public void CreateNewCampaign(string name, int length)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.CreateCampaign(name, length);
        }

        public void CreateNewCampaignOptions(List<string> optionsList, string campaign)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.CreateCampaignOptions(optionsList, campaign);
        }
        public void DeleteUser(string userName)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.DeleteUser(userName);
        }

        public void CreateUser(string username, string password, string role) {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.AddUser( username,password,role);
        }

        public void DeleteUser()
        {

        }
        
    }
}
