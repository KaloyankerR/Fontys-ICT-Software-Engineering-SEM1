using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BickingTrip
{
    internal class Trips
    {
        List<Trip> trips;

        public Trips()
        {
            trips = new List<Trip>();
        }
        
        public void AddTrip(Trip trip)
        {
            trips.Add(trip);
        }


        //public void RemoveTrip()
    }
}
