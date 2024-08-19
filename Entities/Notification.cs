using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Message { get; set; } = default!;
        public string Sender { get; set; } = default!;
        public string Receiver { get; set; } = default!;
        public Guid StaffId { get; set; }
        public Staff Staff { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
