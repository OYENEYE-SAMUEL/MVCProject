using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderFish
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FishId { get; set; }
        public Fish Fish { get; set; } = default!;
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = default!;
    }
}
