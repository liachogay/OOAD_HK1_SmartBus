using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus.Model
{
    public class Bus
    {
        public string Id { get; set; }
        public string No { get; set; }
        public int NumberOfPassenger { get; set; }
        private string DriverId { get; set; }
        public Driver Driver { get; set; }

        public string From { get; set; }
        public string To { get; set; }
    }
}
