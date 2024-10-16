using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BlogAPI.Models
{
    public class Blog
    {
        [Key]
        public int ForumId { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Title must be less than 30 characters.")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(250, ErrorMessage = "Message must be less than 250 characters.")]
        public string Body { get; set; } = string.Empty;
        public int Like { get; set; }
        public DateTime Created_at { get; set; }
        public List<StatusType>? Statuses { get; set; }
        public List<int>? CategoriesId { get; set; }
        public List<CategoryType>? Categories { get; set; }
        public List<Comment>? Comments { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }
    }
}
