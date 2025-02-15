﻿namespace BlogAPI.Models
{
    public class UserInteractive
    {
        private readonly BlogManagementSystemDbContext _blogManagementSystemDbContext;
        public User? User { get; set; }

        public UserInteractive(BlogManagementSystemDbContext blogManagementSystemDbContext)
        {
            _blogManagementSystemDbContext = blogManagementSystemDbContext;
        }

        public User? CreateUser(string? username)
        {
            if (username is not null && username != string.Empty)
            {
                var user = new User()
                {
                    Username = username,
                    Role = "user",
                    Created_at = DateTime.Now
                };
                _blogManagementSystemDbContext.Users.Add(user);
                _blogManagementSystemDbContext.SaveChanges();

                user = GetUserByUserName(username);
                if (user is not null)
                    return user;
            }
            return null;
        }

        public User? GetUserByUserName(string? username)
        {
            var user = _blogManagementSystemDbContext.Users.FirstOrDefault(un => un.Username == username);
            if (user is not null)
                return user;
            else
                return null;
        }

        public List<User>? GetAllUser() => _blogManagementSystemDbContext.Users.ToList();
    }
}
