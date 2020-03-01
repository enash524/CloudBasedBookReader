using System;

namespace CloudBasedBookReader
{
    public class OnlineSystem : IOnlineSystem
    {
        public bool AddBook(string authorName, string genre, string title)
        {
            throw new NotImplementedException();
        }

        public bool AddReadingHours(int hours)
        {
            throw new NotImplementedException();
        }

        public bool ApplyUserDiscount(Guid userId, int discount)
        {
            throw new NotImplementedException();
        }

        public bool CheckOutBook(Guid userId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public bool FinishReading(Guid userId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public bool IsSubscriptionValid(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void NewBookAdded(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public bool ReadBook(Guid userId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBook(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public bool ResumeReading(Guid userId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public bool SetUserStatus(Guid userId, UserStatus status)
        {
            throw new NotImplementedException();
        }

        public bool StopReading(Guid userId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Book ViewBookInformation(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public User ViewUserInformation(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}