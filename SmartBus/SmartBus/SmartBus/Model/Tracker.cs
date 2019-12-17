using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus.Model
{
    public class Tracker
    {
        public string IDAccount { get; set; }
        public int IDBus { get; set;}
        public int StationUp { get; set; }
        public int StationDown { get; set; }
    }
}
