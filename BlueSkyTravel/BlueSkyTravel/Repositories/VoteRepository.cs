using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Repositories
{
    public class VoteRepository : Repository<Vote>
    {

        public VoteRepository(BlueSkyContext context) : base(context)
        {

        }
    }
}
