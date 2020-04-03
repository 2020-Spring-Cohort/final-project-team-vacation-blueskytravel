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
        public virtual ForFun ForFun { get; set; }
        public virtual int ForFunId { get; set; }

        public Vote()
        {

        }

        public Vote(int id, bool voteChoice, int forFunId)
        {
            Id = id;
            VoteChoice = voteChoice;
            ForFunId = forFunId;
        }
    }
}
