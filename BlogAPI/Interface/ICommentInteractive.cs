using BlogAPI.Models;

namespace BlogAPI.Interface
{
    public interface ICommentInteractive
    {
        List<Comment>? Comments { get; set; }
        List<Comment>? GetAll();
        Comment? GetById(int id);
        void Create(Comment comment);
        void Edit(Comment comment);
        void Delete(int id);
    }
}
