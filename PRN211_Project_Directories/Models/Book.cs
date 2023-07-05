using System;
using System.Collections.Generic;

namespace PRN211_Project_LibraryManagement.Models
{
    public partial class Book
    {
        public Book()
        {
            Borrowings = new HashSet<Borrowing>();
        }

        public int BookId { get; set; }
        public int? Quantity { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string? CoverPictureUrl { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
