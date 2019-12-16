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
        public string Id { get; set; }

        public string Password { get; set; }

        public string TypeAccount { get; set; }

        public string Name { get; set; }

        private int Age { get; set; }
        // Bank Account : private
        private string BankAccountId { get; set; }

        public bool isStudent { get; set; }

        public int getAge()
        {
            return this.Age;
        }

        public int? pay(int Money)
        {
            if (this.BankAccountId == "")
                return null;
            return Money;
        }
    }
}
