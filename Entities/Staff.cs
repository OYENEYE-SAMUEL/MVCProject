using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Staff
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? Address { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string Qualification { get; set; } = default!;
        public int YearOfExperience { get; set; }
        public Gender Gender { get; set; }
        //public ICollection<Notification> Notification { get; set; } = new HashSet<Notification>();
        /*public ICollection<Fish> Fishes { get; set; } = new HashSet<Fish>();
        public ICollection<Pond> Ponds { get; set; } = new HashSet<Pond>();
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();*/
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
