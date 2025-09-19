namespace UserRepositories;
using UserEntities;

public class UserRepository: IUserRepository
{


    public UserRepository()
    {
    
     }
    public IEnumerable<User>? GetAllUsers()
    {
        return JsonUserManager.LoadUsers();
    }

     public User? GetUserByEmail(string email)
    {
        var users = GetAllUsers();
        return users.FirstOrDefault(u => 
            u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
}
