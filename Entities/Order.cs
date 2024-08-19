using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Status OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateOrder { get; set; } = DateTime.UtcNow;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public Guid? StaffId { get; set; }
        public Staff Staff { get; set; }
        public ICollection<OrderFish> OrderFishItems { get; set; } = new HashSet<OrderFish>();  
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class OrderFish
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Key { get; set; } = default!;
        public int Value { get; set; } = default!;
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = default!;
    }
}
