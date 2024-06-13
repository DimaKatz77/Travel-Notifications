using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Travel_Notifications.Common;
using Travel_Notifications.Model.Notification;
using Travel_Notifications.Model.Search;
using Travel_Notifications.Services;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        //Get Active User Notifications
        [HttpGet("get")]
        public  IActionResult GetNotifications(Paginator page, Guid userId)
        {
            return  Ok(_notificationService.GetUserNotifications(page,userId));
        }

        //Get Notification By ID
        [HttpGet("get_byid")]
        public IActionResult GetNotification(int notificationId) 
        {
            return Ok(_notificationService.GetNotificationById(notificationId));
        }

        //Create Notification
        [HttpPost("create")]
        public IActionResult CreateNotification(NotificationRequest item)
        {
            return Ok(_notificationService.CreateNotification(item));
        }

        //Delete Notification
        [HttpDelete("delete")]
        public IActionResult DeleteNotification(int id)
        {
            return Ok(_notificationService.DeleteNotification(id));
        }
    }
}
