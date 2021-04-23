using Secretta.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Secretta.External_Interfaces
{
    public interface ITaskRepository
    {
        TaskDTO GetTaskById(int taskId);
        IEnumerable<TaskDTO> GetTasksByUserId(int userId);
    }
}
