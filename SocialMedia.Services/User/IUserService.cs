// TODO Add using statment for Task and UserRegister  

namespace SocialMedia.Services.User
{
    public interface IUserService
    {
        // TODO Add in method
        Task<bool> RegisterUserAsync(UserRegister model);
        Task<UserDetail> GetUserByIdAsync(int userId);
        // Task<UserEntity> GetUserByEmailAsync(string email);
        // Task<UserEntity> GetUserByUsernameAsync(string username);
        // Task<bool> UpdateUserAsync(UserUpdate request);
        // Task<bool> DeleteUserAsync(int userId);

    }
}