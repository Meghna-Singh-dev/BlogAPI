namespace BlogAPI.Interface
{
    public interface ICategoryInteractive
    {
        List<Category> Categories { get; set; }
        void UpdateCategories();
    }
}
