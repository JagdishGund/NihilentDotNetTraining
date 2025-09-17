namespace UserRepositories;
using UserEntities;
using System.Collections.Generic;

public interface IUserRepository
{

    IEnumerable<User> GetAllUsers();
    User? GetUserByEmail(string email);
}