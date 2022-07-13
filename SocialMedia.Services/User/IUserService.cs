namespace SocialMedia.Services.User
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync();
        Task<> GetUserByIdAsync();
        // Task<> GetUserByUsernameAsync();
        // Task<bool> UpdateUserAsync();
        // Task<bool> DeleteUserAsync();

    }
}