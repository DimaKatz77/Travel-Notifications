namespace Travel_Notifications.Model.Search
{
    public class SearchResult
    {
        public string FlightNumber { get; set; }
        public decimal PriceInDollar { get; set; }
        public DateTime DepartDateTime { get; set; }
        public DateTime ArriveDateTime { get; set; }
        public string DepartAiroportCode { get; set; }
        public string ArriveAiroportCode { get; set; }
        public string AirlineCompany { get; set; }

    }
}
