using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Repositories
{
    public class ItineraryRepository : Repository<Itinerary>
    {
        public ItineraryRepository(BlueSkyContext context) : base(context)
        {

        }
    }
}
