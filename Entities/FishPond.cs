using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FishPond
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FishId { get; set; }
        public Guid PondId { get; set; }
        public Fish Fish { get; set; } = default!;
        public Pond Pond { get; set; } = default!;
    }
}
