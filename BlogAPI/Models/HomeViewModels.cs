namespace BlogAPI.Models
{
    public class HomeViewModels
    {
        public User? User { get; set; }
        public List<User>? Users { get; set; }
        public List<Blog>? Forums { get; }
        public Blog? Forum { get; set; }
        public Blog? MetaData { get; set; }
        public Comment? Comment { get; set; }

        public HomeViewModels(List<Blog>? forums, List<User>? users, User? user, Blog? forum)
        {
            Forums = forums;
            User = user;
            Users = users;
            Forum = forum;
        }
    }
}
