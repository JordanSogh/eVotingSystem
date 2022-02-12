using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{
     public class Vote
    {
        private int ballot;
        private string ballotDescription;


        public int Ballot { get => ballot; set => ballot = value; }
        public string BallotDescription { get => ballotDescription; set => ballotDescription = value; }
    }
}
