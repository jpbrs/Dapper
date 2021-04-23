using Secretta.Entity;

namespace Secretta.External_Interfaces
{
    public interface IUserRepository
    {
        UserDTO GetUserByName(string name);
        UserDTO GetUserById(int userId);
    }
}
