namespace Portfolio.Models
{
    public class LeonorViewModel
    {
        public string Name { get; set; } = "Lance Leonor";
        public string Status { get; set; } = "Computer Science Student";
        public string Bio { get; set; } =
            "🎓 2nd-year Computer Science student\n" +
            "💻 Learning C, Java, and C#\n" +
            "🌐 Basic knowledge of HTML and CSS\n" +
            "🚀 Improving my skills through projects\n" +
            "and continuous learning";
        public ContactInformation Contact { get; set; } = new();
        public List<string> Hobbies { get; set; } = 
        [
            "🍳 Cooking",
            "🧁 Baking",
            "🏓 Pickle Ball",
            "🏐 Volleyball",
            "⛸️ Skating",
            "🎮 Gaming"
        ];

        public List<ProgrammingLanguage> Languages { get; set; } =
        [
            new("C", "Intermediate"),
            new("Java", "Intermediate"),
            new("C#", "Upper Beginner"),
            new("HTML", "Low Intermediate"),
            new("CSS", "Low Intermediate")
        ];
    }

    public class ContactInformation
    {
        public string Email { get; set; } = "lanceyurhi28@gmail.com";
        public string Phone { get; set; } = "0960-620-0340";
        public string Location { get; set; } = "Manila, Philippines";
        public string GitHub { get; set; } = "https://github.com/Zhytroxx";
    }

    public class ProgrammingLanguage
    {
        public string Name { get; set; }
        public string Proficiency { get; set; }

        public ProgrammingLanguage(string name, string proficiency)
        {
            Name = name;
            Proficiency = proficiency;
        }
    }
}