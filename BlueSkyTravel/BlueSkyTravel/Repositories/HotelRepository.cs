using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Repositories
{
    public class HotelRepository : Repository<Hotel>
    {
        public HotelRepository(BlueSkyContext context) : base(context)
        {

        }
    }
}
