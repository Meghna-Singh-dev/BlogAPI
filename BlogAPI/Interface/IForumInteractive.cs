using BlogAPI.Models;
using System.Reflection.Metadata;

namespace BlogAPI.Interface
{
    public interface IForumInteractive
    {
        List<Blog>? Forums { get; set; }
        void CreateForum(Blog forum);
        void EditForum(Blog forum);
        void RemoveForum(int? id);
        List<Blog>? GetAllForums();
        List<Blog>? GetForumsByTags(List<StatusType> statuses, List<CategoryType> categories);
        List<Blog>? GetForumsByUserId(int userId);
    }
}
