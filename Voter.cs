using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     class Voter : User
    {
        private bool loggedIn;
        private string userName;
        private string password;
        private string role = "Voter";

        public Voter(bool loggedInC, string userNameC, string passwordC)
        {
            loggedIn = loggedInC;
            userName = userNameC;
            password = passwordC;
        }

        
        

    }
}
