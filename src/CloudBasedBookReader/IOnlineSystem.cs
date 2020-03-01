using System;

namespace CloudBasedBookReader
{
    public interface IOnlineSystem
    {
        bool AddBook(string authorName, string genre, string title);

        bool AddReadingHours(int hours);

        bool ApplyUserDiscount(Guid userId, int discount);

        bool CheckOutBook(Guid userId, Guid bookId);

        bool FinishReading(Guid userId, Guid bookId);

        bool IsSubscriptionValid(Guid userId);

        void NewBookAdded(Guid bookId);

        bool ReadBook(Guid userId, Guid bookId);

        bool RemoveBook(Guid bookId);

        bool ResumeReading(Guid userId, Guid bookId);

        bool SetUserStatus(Guid userId, UserStatus status);

        bool StopReading(Guid userId, Guid bookId);

        Book ViewBookInformation(Guid bookId);

        User ViewUserInformation(Guid userId);
    }
}