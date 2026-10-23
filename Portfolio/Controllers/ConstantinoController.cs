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
                HeadLine = "CS Student | Aspiring Low Level System Engineer",
                ShortIntro = "I am a Computer Science student who enjoys building software that solves practical problems. My interests include systems programming in C, game development and full-stack web development. I focus on writing clear, maintainable code, and I enjoy figuring out how things work and improving what I build.",
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
