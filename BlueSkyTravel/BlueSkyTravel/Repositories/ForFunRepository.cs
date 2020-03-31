using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSkyTravel.Repositories
{
    public class ForFunRepository : Repository<ForFun>
    {

        public ForFunRepository(BlueSkyContext context) : base(context)
        {
                
        }
    }
}
