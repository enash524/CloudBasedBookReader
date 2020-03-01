using System;

namespace CloudBasedBookReader
{
    public class Book
    {
        public string AuthorName { get; set; }

        public Guid BookId { get; set; }

        public string Genre { get; set; }

        public int NumberOfUsersCurrentlyReadingBook { get; set; }

        public string Title { get; set; }

        public int TotalNumberOfTimesBookIsViewed { get; set; }
    }
}