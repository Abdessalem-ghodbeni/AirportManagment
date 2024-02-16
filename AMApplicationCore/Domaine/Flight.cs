using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domaine
{
    public class Flight
    {
        public Flight() { }

        public Flight(int flightId, DateTime flightDate, int estimatedDuration, DateTime effectiveArrival, string departure, string destination)
        {
            FlightId = flightId;
            FlightDate = flightDate;
            EstimatedDuration = estimatedDuration;
            EffectiveArrival = effectiveArrival;
            Departure = departure;
            Destination = destination;
        }
        #region
        //private string name;
        //public string getName()
        //{
        //    return this.name;
        //}
        //public void setName(string name)
        //{
        //    this.name = name;
        //}
        #endregion

        //private string name;
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Passenger>Passengers { get; set; }

    }
}
