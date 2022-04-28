using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Common.DTOs;
using Common.ViewModels;
using Services;

namespace ProiectApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _map;

        public UserController(IUserService userService, IMapper map)
        {
            _userService = userService;
            _map = map;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<UserViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var result = await _userService.GetUsersAsync();
                if (result.Count == 0)
                {
                    return NoContent();
                }
                return Ok(_map.Map<List<UserViewModel>>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message,
                });
            }
        }

        [HttpGet("{userId}")]
        [ProducesResponseType(typeof(UserViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserById([FromRoute] int userId)
        {
            try
            {
                var result = await _userService.GetUserById(userId);
                if(result == null)
                {
                    return NoContent();
                }
                return Ok(_map.Map<UserViewModel>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message,
                });
            }
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(UserViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login([FromBody] LoginUserRequest loginUser)
        {
            try
            {
                var result = await _userService.Login(_map.Map<LoginUserDto>(loginUser));
                return Ok(_map.Map<UserViewModel>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message,
                });
            }
        }

        [HttpPost("register")]
        [ProducesResponseType(typeof(UserViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest registerUser)
        {
            try
            {
                var result = await _userService.Register(_map.Map<RegisterUserDto>(registerUser));
                return Ok(_map.Map<UserViewModel>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message,
                });
            }
        }
    }
}
