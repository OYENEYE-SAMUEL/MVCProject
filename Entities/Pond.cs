using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pond
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int PondSize { get; set; } = default!;
        public string Dimension { get; set; } = default!;
        public int SpaceRemain { get; set; }
        public Guid StaffId { get; set; }
        public Staff Staff { get; set; }
        public ICollection<FishPond> FishPonds { get; set; } = new HashSet<FishPond>();
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
