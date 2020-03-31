using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Repositories
{
    public class FlightRepository : Repository<Flight>
    {
        public FlightRepository(BlueSkyContext context) : base(context)
        {
        }
    }
}
