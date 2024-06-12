using Travel_Notifications.Common;
using Travel_Notifications.Model.User;

namespace Travel_Notifications.Services.Interfaces
{
    public interface IUserService
    {
        Task UpsertUser(UserDTO request);
        Task<List<UserDTO>> GetUsers(Paginator page);
        Task<UserDTO> GetUser(Guid id);
        Task DeleteUser(Guid UserId);
    }
}
