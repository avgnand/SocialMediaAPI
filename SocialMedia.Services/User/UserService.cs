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
        // var userEntity = await _dbContext.Users.FindAsync(request.Id);

        // // By using the null conditional operator we can check if it's null at the same time we check the OwnerId
        // // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
        // if (userEntity?.Id != _userId)
        // {
        // return false;
        // }

        // // Now update the entity's properties
        // userEntity.Username = request.Username;
        // userEntity.Email = request.Email;
        // userEntity.FirstName = request.FirstName;
        // userEntity.LasyName = request.Lastname;

        // // Save the changes to the database
        // var numberOfChanges = await _dbContext.SaveChangesAsync();

        // // numberOfChanges is stated to be equal to 1 because only one row is updated
        // return numberOfChanges == 1;
        // }

        // * DELETE Delete a user
        // public async Task<bool> DeleteUserAsync(int userId) {
        // // Fint the user bt the given Id
        // var userEntity = await _dbContext.Users.FindAsync(userId);

        // // Validate the user exists and is owned by the user
        // if (userEntity?.Id != _userId)
        // {
        // return false;
        // }

        // // Remove the user from the DbContext and assert that the one change was saved
        // _dbContext.Users.Remove(userEntity);
        // return await _dbContext.SaveChangesAsync() == 1;
        // }
    }
}