using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;
using BlueSkyTravel.Areas.Identity.Data;


namespace BlueSkyTravel.Repositories
{
    public class FlightRepository : Repository<Flight>
    {
        public FlightRepository(UserDbContext context) : base(context)
        {
        }
    }
}
