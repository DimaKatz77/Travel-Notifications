using Travel_Notifications.Model.FlightInfo;

namespace Travel_Notifications.Services.Interfaces
{
    public interface IFlightInfoService
    {
        Task<int> CreateFlightInfo(FlightInfoDTO item);
        Task<FlightInfoDTO> GetInfoByFlightNumber(string number);
    }
}
