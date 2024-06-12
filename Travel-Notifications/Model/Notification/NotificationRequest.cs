namespace Travel_Notifications.Model.Notification
{
    public class NotificationRequest
    {
        public int UserId { get; set; }
        public string FlightNumber { get; set; }
        public decimal AskedPriceInDollar { get; set; }
        public DateTime DepartDateTime { get; set; }
        public string DepartAiroportCode { get; set; }
        public string ArriveAiroportCode { get; set; }
        public string AirlineCompany { get; set; }
        public decimal CurrentPriceInDollar { get; set; }
        public DateTime ArriveDateTime { get; set; }

    }
}
