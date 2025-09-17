namespace UserServices;
using UserEntities;
using UserRepositories;

public class UserService: IUserService
{
   public readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User> GetAllUsers()
    {
       return _userRepository.GetAllUsers();
    }

    public User? Validate(string email, string password)
        {
            // Get user from repository
            var user = _userRepository.GetUserByEmail(email);

            // Check if found and password matches (hash compare in real apps!)
            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        } 

        public User? GetUserByEmail(string email)
        {
        var users = GetAllUsers();
        return users.FirstOrDefault(u => 
            u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }  

}
