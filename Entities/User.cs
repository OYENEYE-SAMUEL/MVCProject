﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string ConfirmedPassword { get; set; } = default!;
        public string HashSalt { get; set; } = default!;
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
