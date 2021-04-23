using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Secretta.Entity;

namespace Secretta.External_Interfaces
{
    public class UserRepository : IUserRepository
    {

        private readonly string _connectionString;

        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        public UserDTO GetUserById(int userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var user = connection.QueryFirstOrDefault<UserDTO>(
                     @"SELECT * FROM [SECRETTA].[dbo].[Usuarios] WHERE [UserId] = @Id", new { Id = userId }
                );
                return user;
            }
        }

        public UserDTO GetUserByName(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var user = connection.QueryFirstOrDefault<UserDTO>(
                     @"SELECT * FROM [SECRETTA].[dbo].[Usuarios] WHERE [Username] = @Name", new { Name = name }
                );
                return user;
            }
        }
    }
}
