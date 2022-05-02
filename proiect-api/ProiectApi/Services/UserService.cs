using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Common.DTOs;
using Common.Entities;
using DataPersistence;
using Microsoft.AspNetCore.Identity;

namespace Services
{
    #region interface
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersAsync();
        Task<UserDto> GetUserById(int userId);
        Task<UserDto> Register(RegisterUserDto userDto);
        Task<UserDto> Login(LoginUserDto userDto);
    }
    #endregion
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _map;

        public UserService(DataContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public async Task<UserDto> GetUserById(int userId)
        {
            var response = _map.Map<UserDto>(await _context.Users.FirstOrDefaultAsync(u=>u.Id == userId));
            return response;
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            var response = _map.Map<List<UserDto>>(await _context.Users.ToListAsync());
            return response;
        }

        public async Task<UserDto> Register(RegisterUserDto userDto)
        {
            var isEmailUnique = await _context.Users.AnyAsync(u => u.Email == userDto.Email);
            if (isEmailUnique)
            {
                return null;//email is already in use, change return type
            }
            var user = _map.Map<User>(userDto);

            var hashedPassword = new PasswordHasher<object?>().HashPassword(null, userDto.Password);
            user.HashedPassword = hashedPassword;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return _map.Map<UserDto>(user);
        }

        public async Task<UserDto> Login(LoginUserDto userDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == userDto.Email);

            var hashedPassword = new PasswordHasher<object?>().HashPassword(null, userDto.Password);
            var passwordVerificationResult = new PasswordHasher<object?>().VerifyHashedPassword(null, hashedPassword, userDto.Password);

            if (passwordVerificationResult == PasswordVerificationResult.Success)
            {
                return _map.Map<UserDto>(user);
            }
            return null;
        }

    }
}
