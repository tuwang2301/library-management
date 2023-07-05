using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN211_Project_LibraryManagement.Models
{
    public partial class Borrowing
    {
        public int BorrowingId { get; set; }
        public int AccountId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public int StatusId { get; set; }
        public string? Note { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Book Book { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
    }
}
