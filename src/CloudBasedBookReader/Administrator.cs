using System;

namespace CloudBasedBookReader
{
    public class Administrator
    {
        private readonly IOnlineSystem _onlineSystem;

        public Administrator(IOnlineSystem onlineSystem)
        {
            _onlineSystem = onlineSystem;
        }

        public bool AddBook(string authorName, string genre, string title)
        {
            return _onlineSystem.AddBook(authorName, genre, title);
        }

        public bool ApplyUserDiscount(Guid userId, int discount)
        {
            return _onlineSystem.ApplyUserDiscount(userId, discount);
        }

        public bool RemoveBook(Guid bookId)
        {
            return _onlineSystem.RemoveBook(bookId);
        }

        public bool SetUserStatus(Guid userId, UserStatus status)
        {
            return _onlineSystem.SetUserStatus(userId, status);
        }

        public Book ViewBookInformation(Guid bookId)
        {
            return _onlineSystem.ViewBookInformation(bookId);
        }

        public User ViewUserInformation(Guid userId)
        {
            return _onlineSystem.ViewUserInformation(userId);
        }
    }
}