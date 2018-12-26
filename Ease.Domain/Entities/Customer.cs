using System;
namespace Ease.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime FirstPurchase { get; set; }
        public DateTime LastPurchase { get; set; }
    }
}
