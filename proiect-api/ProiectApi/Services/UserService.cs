using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Common.DTOs;
using Common.Entities;
using DataPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    #region interface
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersAsync();
        Task<UserDto> GetUserById(int userId);
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

    }
}
