// TODO Double check using statements
using System;
using System.ComponentModel.DataAnnotations;
uisng System.Threading.Tasks;
using SocialMedia.Data;
using SocialMedia.Data.Entities;
using SocialMedia.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SocialMedia.Services.User
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        // * POST Create a user - required
        // Add in method
        public async Task<bool> RegisterUserAsync(UserRegister model)
        {
            // Check values from methods for invalid data
            if (await GetUserByIdAsync(model.Id) != null)
            {
                return false;
            }
            // Declare new UserEntity and assign values
            var entity = new UserEntity
            {
                Email = model.Email,
                Username = model.Username,
                Password = model.Password,
                DateCreated = DateTime.Now
            };

            // Hash password entered by user
            var passwordHasher = new PasswordHasher<UserEntity>();

            entity.Password = passwordHasher.HashPassword(entity, model.Password);

            // Add entity to _context.Users DbSet
            _context.Users.Add(entity);
            // Save changes made to the DbSet
            var numberOfChanges = await _context.SaveChangesAsync();

            // Check to see if the user was registered
            return numberOfChanges == 1;
        }

        // * GET User by id - required
        // Add in method
        public async Task<UserDetail> GetUserByIdAsync(int userId)
        {
            // Check to see if user exists
            var entity = await _context.Users.FindAsync(userId);
            if (entity is null)
            {
                return null;
            }

            // Information to be display if user is found
            var userDetail = new UserDetail
            {
                Id = entity.Id,
                Email = entity.Email,
                Username = entity.Username,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateCreated = entity.DateCreated
            };

            return userDetail;
        }

        // * GET User by email
        // public async Task<UserEntity> GetUserByEmailAsync(string email) {
            // return await _context.Users.FirstOrDefaultAsync(user => user.Email.ToLower() == email.ToLower());
        // }

        // * GET User by username
        // public async Task<UserEntity> GetUserByUsernameAsync(string username) {
            // return await _context.Users.FirstOrDefaultAsync(user = user.Username.ToLower() == username.ToLower());
        // }

        // * PUT Update a user
        // public async Task<bool> UpdateUserAsync(UserUpdate request) {
            // // Find the user and validate it's owned by the user
            // var userEntity = await _dbContext
        // }

        // * DELETE Delete a user
        // public async Task<bool> DeleteUserAsync() {

        // }
    }
}