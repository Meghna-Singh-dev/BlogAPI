using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public DateTime Created_at { get; set; }
        public List<Blog>? Forums { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
