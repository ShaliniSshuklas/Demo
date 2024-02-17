using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class Resident
    {
        public Guid Id { get; set; }
        public string? ResidentName { get; set; }
        public string? MobileNo { get; set; }
        public string? Dob { get; set; }
        public bool? IsActive { get; set; }
    }
}
