// TODO Add using statment for Task and UserRegister  
using System.Threading.Tasks;
using SocialMedia.Models.User;
using SocialMedia.Data.Entities;

namespace SocialMedia.Services.User
{
    public interface IUserService
    {
        // TODO Add in method
        Task<bool> RegisterUserAsync(UserRegister model);
        Task<UserEntity> GetUserByIdAsync();
        // Task<> GetUserByUsernameAsync();
        // Task<bool> UpdateUserAsync();
        // Task<bool> DeleteUserAsync();

    }
}