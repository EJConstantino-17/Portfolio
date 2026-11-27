namespace Portfolio.Models
{
    public class ConstantinoProjectViewModel
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Technologies { get; set; } = new();
        public string GitHubUrl { get; set; } = "";
    }
}
