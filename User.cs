using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
    public class User
    {
        private string username;
        private string password;
        public string role;


        public void SetLoginDetails(string passedRole, string passedUsername, string passedPassword)
        {
            username = passedUsername;
            password = passedPassword;
            role = passedRole;
        }



        public void GetUserDetails()
        {


        }
        

    }
}
