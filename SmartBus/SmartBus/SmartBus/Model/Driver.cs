using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus.Model
{
    public class Driver
    {
        private string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public bool getPayment(Customer cus, int Money)
        {
            var _money = cus.pay(Money);
            if (_money == null) return false;
            return true;
        }
    }
}
