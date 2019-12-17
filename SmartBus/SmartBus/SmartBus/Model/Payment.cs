namespace SmartBus.Model
{
    public class Payment
    {
        public string Id { get; set; }

        public int Money { get; set; }

        public string CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string BankAccountId { get; set; }
        public Bank Bank { get; set; }

    }
}
