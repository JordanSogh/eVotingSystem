using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
    class User
    {
        // try enum for roles
         // char(20)
        private string userName;
        private string password;
        private string role;
        public bool LoginUser(string usernameC, string passwordC)
        {
            DatabaseHelper dbHelp = new DatabaseHelper();
            string fetchedUserRole = dbHelp.ValidateLogin(usernameC, passwordC);
            if (fetchedUserRole!= null)
            {
                role = fetchedUserRole;
                

            }




            return true;
        }

        public void SelectUserRole()
        {



        }

        public void LogoutUser()
        {

        }


    }
}
