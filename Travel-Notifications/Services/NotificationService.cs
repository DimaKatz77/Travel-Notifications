using Travel_Notifications.Common;
using Travel_Notifications.Model.FlightInfo;
using Travel_Notifications.Model.Notification;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IFlightInfoService _flightInfoService;

        public NotificationService(IFlightInfoService flightInfoService)
        {
            _flightInfoService = flightInfoService;
        }

        public async Task CreateNotification(NotificationRequest item)
        {
            //Steps
            //1.....
            //Check is Flight Info exist
            var flight = await _flightInfoService.GetInfoByFlightNumber(item.FlightNumber);
            if (flight == null)
            {
                //Create Flight object
                var _flightInfo = new FlightInfoDTO
                {
                    FlightNumber = item.FlightNumber,
                    AirlineCompany = item.AirlineCompany,
                    ArriveAiroportCode = item.ArriveAiroportCode,
                    ArriveDateTime = item.ArriveDateTime,
                    CurrentPriceInDollar = item.CurrentPriceInDollar,
                    DepartAiroportCode = item.DepartAiroportCode,
                    DepartDateTime = item.DepartDateTime
                };
                await _flightInfoService.CreateFlightInfo(_flightInfo);
            }
            //Create Notification
            var _notificationDTO = new NotificationDTO
            {
                AskedPriceInDollar = item.AskedPriceInDollar,
                FlightNumber = item.FlightNumber,
                UserId = item.UserId
            };
            //2. Create Notification Record In DB

            //3. Create Redis Record flight Number / AskedPriceInDollar

            //4. Create Airline Company flight subscribe (the company will send the flight price updates to your API endpoint)



        }

        public async Task DeleteNotification(int Id)
        {
           //Delete Notification Record in DB and in Redis

           
        }

        public Task<NotificationDTO> GetNotificationById(int notificatioId)
        {
            //Get Notification Record By NotificationId
            return null;
        }


        public Task<List<NotificationDTO>> GetUserNotifications(Paginator page, Guid userId)
        {
            // Get Active Notifications By user Id
            return null;
        }
    }
}
