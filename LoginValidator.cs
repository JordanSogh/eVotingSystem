using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
    public class LoginValidator
    {
        private string userName;
        private string password;
        private string role;

        
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Role { get => role; set => role = value; }

        public bool LoginUser(string usernameC, string passwordC)
        {
            bool userFound = false;

            DatabaseHelper dbHelp = new DatabaseHelper();
            string fetchedUserRole = dbHelp.ValidateLogin(usernameC, passwordC);
            if (fetchedUserRole!= null)
            {
                userFound = true;
                UserName = usernameC;
                Password = passwordC;
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
