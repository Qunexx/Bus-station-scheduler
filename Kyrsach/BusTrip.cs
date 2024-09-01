using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kyrsach
{

    public class BusTrip
    {
        public string TripNumber { get; set; }
        public string BusType { get; set; }
        public BusRoute Route { get; set; }
        public DateTime DepartureTime { get; set; }
        public int TravelHours { get; set; }
        public int TravelMinutes { get; set; }
        public int TotalSeats { get; set; }
        public int FreeSeats { get; set; }
        public int BookedSeats { get; set; }
        public int SoldSeats { get; set; }

        [XmlIgnore]
        public TimeSpan TravelTime
        {
            get { return new TimeSpan(TravelHours, TravelMinutes, 0); }
            set
            {
                TravelHours = value.Hours;
                TravelMinutes = value.Minutes;
            }
        }

        public BusTrip()
        {
            Route = new BusRoute();
        }

        public string RouteName => Route.RouteName;
    }
}

