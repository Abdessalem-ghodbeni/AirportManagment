using AMApplicationCore.Domaine;
using AMApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Services
{
    public class FlightMethode : IFlight
    {
        IList<Flight> Flights = new List<Flight>();



        public IList<DateTime> GetFlightDates1(string destination)
        {
            IList<DateTime> filteredFlightDates = new List<DateTime>();

            foreach (var a in Flights)
            {

                if (a.Destination == destination)
                {
                    filteredFlightDates.Add(a.FlightDate);
                }
            }

            return filteredFlightDates;
        }




        public double DurationAverage(string destination)
        {
            var query = from f in Flights
                        where f.Destination == destination
                        select f.EstimatedDuration;
            return query.Average();
        }

        public IList<DateTime> GetFlightDates(string destination)
        {
            var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query.ToList();
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            DateTime endDate = startDate.AddDays(7);

            var query = from f in Flights
                        where f.FlightDate >= startDate && f.FlightDate < endDate
                        select f;

            return query.Count();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in plane.flights
                        select new { f.Destination, f.FlightDate };
            foreach (var f in query)
            {
                Console.WriteLine("Destination : " + f.Destination + "Flight Date : " + f.FlightDate);
            }
        }

        public void DestinationGroupedFlights()
        {
            throw new NotImplementedException();
        }
    }
}







