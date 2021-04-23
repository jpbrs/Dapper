using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Secretta.Entity;
using Secretta.External_Interfaces;

namespace Secretta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private IUserRepository _userRepository { get; }
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpGet("id/{userId}")]
        public UserDTO GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }

        [HttpGet("name/{userName}")]
        public UserDTO GetUserByName(string userName)
        {
            return _userRepository.GetUserByName(userName);
        }
    }
}
