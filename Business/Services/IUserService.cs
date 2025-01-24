using Data.Entities;

namespace Business.Services;

public interface IUserService
{
    UserEntity CreateUser(UserEntity userEntity);
    IEnumerable<UserEntity> GetUsers();
    UserEntity GetUserById(int userId);
    UserEntity GetUserByEmail(string email);
    UserEntity UpdateUser(UserEntity userEntity);
    bool DeleteUserById(int userId);
}