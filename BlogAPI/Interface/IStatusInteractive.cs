using BlogAPI.Models;

namespace BlogAPI.Interface
{
    public interface IStatusInteractive
    {
        List<Blog>? HotStatus { get; set; }
        List<Blog>? NewStatus { get; set; }
        List<Blog> Statuses { get; set; }
        void UpdateStatus(List<Blog>? forums);
    }
}
