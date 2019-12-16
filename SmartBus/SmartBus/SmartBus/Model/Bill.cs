using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus.Model
{
    public class Bill
    {

        public Bill(Customer cus, Bus bus)
        {
            this.BillId = DateTime.Now.ToString() + bus.Id;
            CustomerName = cus.Name;
            BusId = bus.Id;
            DriverName = bus.Driver.Name;
            printDate = DateTime.Now;
        }

        private string BillId { get; set; }
        public string CustomerName { get; set; }
        public string BusId { get; set; }
        public string DriverName { get; set; }
        public DateTime printDate { get; set; }
    }
}
