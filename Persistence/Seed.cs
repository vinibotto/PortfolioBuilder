using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Projects.Any()) return;
            
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Portfolio Builder",
                    Description = " Website dedicated to manage and create your own Portfolio",
                    Category = "WebApplication",
                    Skills="React;.Net;TypeScript;C#",
                    Link="http://localhost:3000"
                },
                new Project
                {
                    Title = "Made up project",
                    Description = "made up project",
                    Category = "WebApplication",
                    Skills="React;.Net;TypeScript;C#",
                    Link="http://localhost:3000"
                },
                new Project
                {
                    Title = "World Peace project",
                    Description = "One can dream.",
                    Category = "WebApplication",
                    Skills="React;.Net;TypeScript;C#",
                    Link="http://localhost:3000"
                },
                new Project
                {
                    Title = "Make a Song",
                    Description = "For the creative ones.",
                    Category = "WebApplication",
                    Skills="React;.Net;TypeScript;C#",
                    Link="http://localhost:3000"
                },
                new Project
                {
                    Title = "Write a book",
                    Description = "Lorem Ipsum Dolor...",
                    Category = "WebApplication",
                    Skills="React;.Net;TypeScript;C#",
                    Link="http://localhost:3000"
                }
            };
            await context.Projects.AddRangeAsync(projects);
            await context.SaveChangesAsync();
        }
    }
}
