using System;
using System.Collections.Generic;

namespace PRN211_Project_LibraryManagement.Models
{
    public partial class Account
    {
        public Account()
        {
            Borrowings = new HashSet<Borrowing>();
            UserProfiles = new HashSet<UserProfile>();
        }

        public int AccountId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public bool Status { get; set; }

        public virtual ICollection<Borrowing> Borrowings { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
