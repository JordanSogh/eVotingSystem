using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
    public class LoginUser
    {
        private string _userName;
        private string _password;
        private string _role;

        
        public string Password { get => _password; set => _password = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Role { get => _role; set => _role = value; }

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
