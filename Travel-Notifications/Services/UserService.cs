using Travel_Notifications.Common;
using Travel_Notifications.Model.User;
using Travel_Notifications.Services.Interfaces;

namespace Travel_Notifications.Services
{
    public class UserService : IUserService
    {

        public async Task DeleteUser(Guid UserId)
        {
            //Set User IsActive field to False
        }

        public async Task<UserDTO> GetUser(Guid id)
        {
            // Get the User ById from a DB By Pages
            return new UserDTO();
        }

        public async Task<List<UserDTO>> GetUsers(Paginator page)
        {
            // Get the Active Users from a DB By Pages
            return new List<UserDTO>();
        }

        public async Task UpsertUser(UserDTO request)
        {
            //Steps
            //if request.UserId is not Null -> Update the User in DB
            //else Create a new User
        }
    }
}
