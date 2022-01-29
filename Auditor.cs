using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
    class Auditor
    {
        private bool loggedIn;
        private string userName;
        private string password;
        private string role = "Auditor";

        public Auditor(bool loggedInC, string userNameC, string passwordC)
        {
            loggedIn = loggedInC;
            userName = userNameC;
            password = passwordC;
        }
    }
}
