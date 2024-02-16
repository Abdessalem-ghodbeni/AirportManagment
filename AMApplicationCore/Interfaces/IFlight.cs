using AMApplicationCore.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AMApplicationCore.Interfaces
{
    public interface IFlight
    {
        IList<DateTime> GetFlightDates(string destination);

        ///herrreee
        /// 

        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IEnumerable<Flight> OrderedDurationFlights();
        void DestinationGroupedFlights();
    }
}
