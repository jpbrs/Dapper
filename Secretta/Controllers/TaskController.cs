using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Secretta.Entity;
using Secretta.External_Interfaces;
using System.Collections.Generic;

namespace Secretta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private ITaskRepository _taskRepository { get; }
        private readonly ILogger<TaskController> _logger;
        public TaskController(ILogger<TaskController> logger, ITaskRepository taskRepository)
        {
            _logger = logger;
            _taskRepository = taskRepository;
        }

        [HttpGet("taskid/{taskId}")]
        public TaskDTO GetTaskById(int taskId)
        {
            return _taskRepository.GetTaskById(taskId);
        }

        [HttpGet("userid/{userid}")]
        public IEnumerable<TaskDTO> GetTasksByUserId(int userId)
        {
            
            return _taskRepository.GetTasksByUserId(userId);
        }
    }
}
