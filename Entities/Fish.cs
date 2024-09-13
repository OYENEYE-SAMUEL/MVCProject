using Domain.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fish
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = default!;
        public string Period { get; set; } = default!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public CategoryType CategoryType { get; set; }  
        public ICollection<FishPond> FishPonds { get; set; } = new HashSet<FishPond>();
        public ICollection<OrderFish> OrderFishes { get; set; } = new HashSet<OrderFish>();
        public string FishImage { get; set; } = default!;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
