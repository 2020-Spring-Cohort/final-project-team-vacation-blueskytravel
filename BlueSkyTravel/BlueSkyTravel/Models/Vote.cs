using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public bool VoteChoice { get; set; }

        public Vote()
        {

        }

        public Vote(int id, bool voteChoice)
        {
            Id = id;
            VoteChoice = voteChoice;
        }
    }
}
