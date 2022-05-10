using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Common.DTOs;
using Common.Entities;
using DataPersistence;
using System.Security.Cryptography;
using System.Text;

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

            var hashedPassword = ComputeSha256Hash(userDto.Password);
            user.HashedPassword = hashedPassword;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return _map.Map<UserDto>(user);
        }

        public async Task<UserDto> Login(LoginUserDto userDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == userDto.Email);

            if (user == null)
            {
                return null;
            }

            var hashedPassword = ComputeSha256Hash(userDto.Password);

            var matched = false;
            if(user.HashedPassword == hashedPassword)
            {
                matched = true;
            }

            if (matched)
            {
                return _map.Map<UserDto>(user);
            }
            return null;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
