namespace UserServices;
using UserRepositories;
using UserEntities;

public interface IUserService
{

    IEnumerable<User> GetAllUsers();
    User? Validate(string email, string password);


}