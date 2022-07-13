using SocialMedia.Data;

namespace SocialMedia.Services.User
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context) {
            _context = context;
        }
        // * POST Create a user - required
        public async Task<bool> RegisterUserAsync() {

        }

        // * GET User by id - required
        public async Task<> GetUserByIdAsync() {

        }

        // * GET User by username
        // public async Task<> GetUserByUsernameAsync() {

        // }

        // * PUT Update a user
        // public async Task<bool> UpdateUserAsync() {

        // }

        // * DELETE Delete a user
        // public async Task<bool> DeleteUserAsync() {

        // }
    }
}