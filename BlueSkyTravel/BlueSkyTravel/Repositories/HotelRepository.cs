using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;
using BlueSkyTravel.Areas.Identity.Data;


namespace BlueSkyTravel.Repositories
{
    public class HotelRepository : Repository<Hotel>
    {
        public HotelRepository(UserDbContext context) : base(context)
        {

        }
    }
}
