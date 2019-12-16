using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus.Model
{
    public class CheckSys
    {

        public Bill printBill(Customer customer, Bus bus)
        {
            return new Bill(customer, bus);
        }
    }
}
