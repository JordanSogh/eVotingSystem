using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Vote
    {
        private int _ballot;
        private string _ballotDescription;

        public int Ballot { get => _ballot; set => _ballot = value; }
        public string BallotDescription { get => _ballotDescription; set => _ballotDescription = value; }
    }
}
