using System;
using System.Collections.Generic;

namespace CloudBasedBookReader
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public List<KeyValuePair<Guid, Guid>> BooksCheckedOutByUsers { get; set; } = new List<KeyValuePair<Guid, Guid>>();
    }
}