using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach
{
    public class BusRoute
    {
        public string RouteName { get; set; }
        public string Destination { get; set; }
        public List<Stop> Stops { get; set; }

        public BusRoute()
        {
            Stops = new List<Stop>();
        }
    }

}
