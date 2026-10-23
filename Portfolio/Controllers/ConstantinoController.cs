using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ConstantinoController : Controller
    {
        public IActionResult Index()
        {
            var portfolio = new ConstantinoViewModel
            {
                Name = "Eduardo D. Constantino III",
                HeadLine = "CS Student | Aspiring Full Stack Developer",
                ShortIntro = "I like to contribute to technology that makes people's live easier.",
                Hobbies = new List<string> { "Coding", "Gaming", "Music", "Chess" },
                Skills = new List<string> { "C", "Python", "JavaScript", "React", "NodeJS", "ExpressJS", "C#", "ASP.NET Core MVC" },
                Email = "ej.constantino.17@gmail.com",
                GitHubUrl = "https://github.com/EJConstantino-17",
                LinkedInUrl = "https://www.linkedin.com/in/ej-constantino-03993942a/"
            };
            return View(portfolio);
        }
    }
}
