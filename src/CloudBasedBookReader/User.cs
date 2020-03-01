using System;

namespace CloudBasedBookReader
{
    public class User
    {
        public int AllowedNumberOfBooksCheckedOut { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RemainingReadingHours { get; set; }

        public UserStatus Status { get; set; }

        public int SubscriptionReadingHours { get; set; }

        public int TotalNumberOfBooksCheckedOut { get; set; }

        public Guid UserId { get; set; }

        public string UserName { get; set; }
    }
}