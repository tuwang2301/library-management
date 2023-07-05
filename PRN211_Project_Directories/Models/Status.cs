using System;
using System.Collections.Generic;

namespace PRN211_Project_LibraryManagement.Models
{
    public partial class Status
    {
        public Status()
        {
            Borrowings = new HashSet<Borrowing>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
