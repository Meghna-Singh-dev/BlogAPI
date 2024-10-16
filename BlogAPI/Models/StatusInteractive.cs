namespace BlogAPI.Models
{
    public class StatusInteractive
    {
        public List<Blog>? HotStatus { get; set; }
        public List<Blog>? NewStatus { get; set; }
        public List<Status> Statuses { get; set; }

        public StatusInteractive()
        {
            Statuses = [new Status
        {
            Id = 1,
            Name = "Hot",
            Forums = HotStatus
        },
        new Status
        {
            Id = 2,
            Name = "New",
            Forums = NewStatus
        }];
        }
        public void UpdateStatus(List<Blog>? forums)
        {
            HotStatus = [];
            NewStatus = [];

            if (forums is not null)
            {
                HotStatus.AddRange(GetHotStatusForum(forums));
                NewStatus.AddRange(GetNewStatusForum(forums));
                Statuses[0].Forums = HotStatus;
                Statuses[1].Forums = NewStatus;
            }
        }
        private List<Blog> GetHotStatusForum(List<Blog> forums)
        {
            // Hot is top 10 calculate by the most like/day
            return forums.OrderByDescending(f => f.Like / CalculateHot(f.Created_at)).Take(10).ToList();
        }

        private int CalculateHot(DateTime created_at)
        {
            int calc = (DateTime.Now - created_at).Hours;
            return calc > 0 ? calc : 1;
        }

        private List<Blog> GetNewStatusForum(List<Blog> forums)
        {
            // New is all forum in a day.
            return [.. forums.Where(f => (DateTime.Now - f.Created_at).TotalDays <= 1)];
        }
    }
}
