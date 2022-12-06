using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BickingTrip;

namespace BickingTrip
{
    internal class Trip
    {
        private string destination;
        private double distance;
        private string rating;

        public Trip(string destination, double distance, string rating)
        {
            this.destination = destination;
            this.distance = distance;
            this.rating = rating;
        }

        public string Destination 
        { 
            get { return destination; }
            set { destination = value; }
        }

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string GetInfo()
        {
            return $"{Destination} - {Distance} - {Rating}/4";
        }
    }
}
