namespace Travel_Notifications.Model.Notification
{
    public class NotificationDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FlightNumber { get; set; }
        public decimal AskedPriceInDollar { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
