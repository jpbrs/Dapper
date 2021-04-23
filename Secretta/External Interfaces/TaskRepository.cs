using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Secretta.Entity;
using System;
using System.Collections.Generic;

namespace Secretta.External_Interfaces
{
    public class TaskRepository : ITaskRepository
    {
        private readonly string _connectionString;

        public TaskRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public TaskDTO GetTaskById(int taskId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var task = connection.QueryFirstOrDefault<TaskDTO>(
                     @"SELECT * FROM [SECRETTA].[dbo].[Tarefas] WHERE [ServiceId] = @Id", new { Id = taskId }
                );
                return task;
            }
        }

        public IEnumerable<TaskDTO> GetTasksByUserId(int userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var task = connection.Query<TaskDTO>(
                     @"SELECT * FROM [SECRETTA].[dbo].[Tarefas] WHERE [userId] = @Id ORDER BY [Horario]", new { Id = userId }
                );
                return task;
            }
        }
    }
}
