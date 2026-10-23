namespace Portfolio.Models
{
    public class ConstantinoViewModel
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string HeadLine { get; set; } = "";
        public string ShortIntro { get; set; } = "";

        public List<string> Skills { get; set; } = new();
        public List<string> Hobbies { get; set; } = new();

        public string Email { get; set; } = "";
        public string GitHubUrl { get; set; } = "";
        public string LinkedInUrl { get; set; } = "";
    }
}
