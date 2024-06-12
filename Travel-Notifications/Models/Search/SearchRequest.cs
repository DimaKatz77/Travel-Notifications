namespace Travel_Notifications.Model.Search
{
    public class SearchRequest
    {
        public int UserId { get; set; }
        public string DepartAirportCode { get; set; }
        public string ArriveAirportCode { get; set; }
        public DateTime DepartDate { get; set; }
    }
}
