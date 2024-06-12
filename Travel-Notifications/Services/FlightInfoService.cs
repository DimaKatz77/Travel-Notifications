using Travel_Notifications.Model.FlightInfo;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Services
{
    public class FlightInfoService : IFlightInfoService
    {
        public Task<int> CreateFlightInfo(FlightInfoDTO item)
        {
            //Create A record in the FlightInfo Table
            return Task.FromResult(1); //A Record ID

        }

        public Task<FlightInfoDTO> GetInfoByFlightNumber(string number)
        {
            //Get a record from  FlightInfo Table by a FlightNumber
            return null;
        }
    }
}
