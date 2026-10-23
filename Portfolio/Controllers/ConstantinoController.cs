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
                Email = "ej.constantino.17@gmail.com",
                GitHubUrl = "https://github.com/EJConstantino-17",
                LinkedInUrl = "https://www.linkedin.com/in/ej-constantino-03993942a/",
                Languages = new List<string>
                {
                    "C",
                    "Java",
                    "JavaScript",
                    "C#",
                    "Python"
                },
                WebDevelopment = new List<string>
                {
                    "HTML",
                    "CSS",
                    "React",
                    "Node.js",
                    "Express.js",
                    "ASP.NET Core MVC"
                },
                Tools = new List<string>
                {
                    "Git",
                    "GitHub",
                    "Visual Studio"
                },
                Projects =
                {
                    new ConstantinoProjectViewModel
                    {
                        Title = "Chess Engine",
                        Description = "A chess engine built primarily in C, featuring bitboard move generation, iterative-deepening search, and alpha-beta pruning. Supports UCI-compatible chess interfaces and includes diagnostic tools for testing move generation and search behavior.",
                        Technologies = new List<string> { "C", "C++", "UCI"},
                        GitHubUrl = "https://github.com/EJConstantino-17/Chess-Engine"
                    },
                    new ConstantinoProjectViewModel
                    {
                        Title = "Tetris Game",
                        Description = "A Java desktop Tetris game featuring a 7-bag randomizer, piece holding, upcoming-piece previews, and progressive difficulty. Organizes gameplay logic, rendering, and input handling into separate components.",
                        Technologies = new List<string> { "Java", "Swing" },
                        GitHubUrl = "https://github.com/EJConstantino-17/TetrisGame"
                    }
                }
            };
            return View(portfolio);
        }
    }
}
