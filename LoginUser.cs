using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
    public class LoginUser
    {
        private string userName;
        private string password;
        private string role;

        
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Role { get => role; set => role = value; }

        public bool ValidateAndLoginUser(string username, string password)
        {
            bool userFound = false;

            DatabaseHelper dbHelp = new DatabaseHelper();
            string fetchedUserRole = dbHelp.ValidateLogin(username, password);
            if (fetchedUserRole!= null)
            {
                userFound = true;
                UserName = username;
                Password = password;
                Role = fetchedUserRole;
            }
            return userFound;
            
            //return user info
        }
        


        public void LogoutUser()
        {
            




        }


    }
}
