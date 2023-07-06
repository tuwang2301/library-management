using System;
using System.Collections.Generic;

namespace PRN211_Project_LibraryManagement.Models
{
    public partial class UserProfile
    {
        public int UserProfileId { get; set; }
        public string FullName { get; set; } = null!;
        public int? Age { get; set; }
        public bool? Gender { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
