using Data.Contexts;
using Data.Entities;

namespace Business.Services;

public class UserService(DataContext context) : IUserService
{
    private readonly DataContext _context = context;

    public UserEntity CreateUser(UserEntity userEntity)
    {
        _context.Users.Add(userEntity);
        _context.SaveChanges();
        
        return userEntity;
    }

    //Get back a list of users
    public IEnumerable<UserEntity> GetUsers()
    {
        return _context.Users;
    }

    public UserEntity GetUserById(int id)
    {
        var userEntity = _context.Users.FirstOrDefault(x => x.Id == id);
        return userEntity ?? null!;
    }

    public UserEntity GetUserByEmail(string email)
    {
        var userEntity = _context.Users.FirstOrDefault(x => x.Email == email);
        return userEntity ?? null!;
    }

    public UserEntity UpdateUser(UserEntity userEntity)
    {
        _context.Users.Update(userEntity);
        _context.SaveChanges();
        
        return userEntity;
    }

    public bool DeleteUserById(int id)
    {
        var userEntity = _context.Users.FirstOrDefault(x => x.Id == id);
        if (userEntity != null)
        {
            _context.Users.Remove(userEntity);
            _context.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }
    }
}