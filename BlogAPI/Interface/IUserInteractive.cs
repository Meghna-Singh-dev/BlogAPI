using BlogAPI.Models;

namespace BlogAPI.Interface
{
    public interface IUserInteractive
    {
        public User? User { get; set; }
        User? GetUserByUserName(string? username);
        User? CreateUser(string? username);
        List<User>? GetAllUser();
    }
}
