using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Repositories
{
    public class ForFunRepository : Repository<ForFun>
    {

        public ForFunRepository(BlueSkyContext context) : base(context)
        {
                
        }
    }
}
