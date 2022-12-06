using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BickingTrip;


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
            // Trip trip = Trip(destination, distance, rating);
            // trips.Add(trip);
            trips.Add(trip);
        }

        public void DeleteTrip(int index)
        {
            trips.RemoveAt(index);
        }

        public void DeleteAllTrips()
        {
            trips.Clear();
        }

        public List<Trip> GetTrips()
        {
            return trips;
        }

        public string GetTripInfo(int ind)
        {
            return trips[ind].GetInfo();
        }

        //public void RemoveTrip()
    }
}
