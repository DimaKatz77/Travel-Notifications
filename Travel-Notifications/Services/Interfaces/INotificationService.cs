using Travel_Notifications.Common;
using Travel_Notifications.Model.Notification;

namespace Travel_Notifications.Services.Interfaces
{
    public interface INotificationService
    {
        Task CreateNotification(NotificationRequest item);
        Task DeleteNotification(int Id);
        Task<NotificationDTO> GetNotificationById(int notificatioId);
        Task<List<NotificationDTO>> GetUserNotifications(Paginator page, Guid userId);

    }
}
