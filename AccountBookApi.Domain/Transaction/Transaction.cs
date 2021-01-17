using System;

namespace AccountBookApi.Domain
{
    public class Transaction : BaseEntity
    {
        public string ProductName { get; set; }
        public double Amount { get; set; }
        public DateTime PurchasedOn { get; set; }
        public User PurchasedBy { get; set; }
        public string Notes { get; set; }
    }
}
