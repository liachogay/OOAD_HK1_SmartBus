using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBus.Model
{
    public class Customer
    {
        // MSSV public 
        public string Account { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        public bool isStudent { get; set; }
        // Bank Account : private
        public string BankAccountId { get; set; }


    }
}
