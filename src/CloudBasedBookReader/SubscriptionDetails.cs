namespace CloudBasedBookReader
{
    public class SubscriptionDetails
    {
        public int BookCheckOutLimit { get; set; }

        public int BooksCheckedOut { get; set; }

        public int ReadingHoursLeft { get; set; }

        public int RemainingBookCheckOutLimit => BookCheckOutLimit - BooksCheckedOut;
    }
}