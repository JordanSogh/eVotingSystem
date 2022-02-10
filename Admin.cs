using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Admin
    {
        DatabaseHelper dbHelp = new DatabaseHelper();
        public void CreateNewCampaign(string nameC, int lengthC)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.CreateCampaign(nameC, lengthC);
        }

        public void DeleteUser(string userNameC)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            dbHelp.DeleteUser(userNameC);
        }
        public Campaign getCurrentCampaign()
        {
            return dbHelp.GetCurrentCampaign();
        }
        public void CreateUser() {
        
        }

        public void DeleteUser()
        {

        }
        
    }
}
