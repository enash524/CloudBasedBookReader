using System;
using System.Collections.Generic;

namespace CloudBasedBookReader
{
    public class Client
    {
        private readonly IOnlineSystem _onlineSystem;

        public Client(IOnlineSystem onlineSystem)
        {
            _onlineSystem = onlineSystem;
        }

        public bool RegisterClient(string firstName, string lastName, string userName, string password)
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchBooks(string title, int year, string genre)
        {
            throw new NotImplementedException();
        }

        public bool CheckOutBook(Guid userId, Guid bookId)
        {
            return _onlineSystem.CheckOutBook(userId, bookId);
        }

        public bool StopReading(Guid userId, Guid bookId)
        {
            return _onlineSystem.StopReading(userId, bookId);
        }

        public bool FinishReading(Guid userId, Guid bookId)
        {
            return _onlineSystem.FinishReading(userId, bookId);
        }

        public SubscriptionDetails GetSubscriptionDetails(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}