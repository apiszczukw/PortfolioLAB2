using Microsoft.EntityFrameworkCore;
using PortfolioLAB2.Models;

namespace PortfolioLAB2.DAL
{
    public class ProjectsContext : DbContext
    {


        public DbSet<Project> Projects { get; set; }

        public ProjectsContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var listaProjektow = new List<Project>()
            {
                new Project()
                {
                    Id = 10,
                    Name = "Portfolio Website",
                    Description = "Personal portfolio using HTML, CSS, and JS.",
                    ImageSrc = "https://images.unsplash.com/photo-1581090700227-1c9730b46ec6",
                    Tags = "HTML,CSS,JavaScript"
                },
                new Project()
                {
                    Id = 11,
                    Name = "Weather App",
                    Description = "A simple weather forecast app using API.",
                    ImageSrc = "https://images.pexels.com/photos/212240/pexels-photo-212240.jpeg",
                    Tags = "JavaScript,API,HTML,CSS"
                },
                new Project()
                {
                    Id = 12,
                    Name = "Task Manager",
                    Description = "To-do list application with local storage.",
                    ImageSrc = "https://images.unsplash.com/photo-1554774853-b414d4b8040b",
                    Tags = "JavaScript,HTML,CSS"
                },
                new Project()
                {
                    Id = 13,
                    Name = "Blog Platform",
                    Description = "A simple blogging platform built in ASP.NET.",
                    ImageSrc = "https://images.pexels.com/photos/261579/pexels-photo-261579.jpeg",
                    Tags = "ASP.NET,C#,HTML,CSS"
                },
                new Project()
                {
                    Id = 14,
                    Name = "E-commerce Store",
                    Description = "Online store frontend with product catalog.",
                    ImageSrc = "https://images.unsplash.com/photo-1589187155475-9d4a39e0dd22",
                    Tags = "HTML,CSS,JavaScript"
                },
                new Project()
                {
                    Id = 15,
                    Name = "Chat App",
                    Description = "Real-time chat application using SignalR.",
                    ImageSrc = "https://images.pexels.com/photos/1181244/pexels-photo-1181244.jpeg",
                    Tags = "SignalR,C#,JavaScript"
                },
                new Project()
                {
                    Id = 16,
                    Name = "Recipe Book",
                    Description = "Web app to store and search recipes.",
                    ImageSrc = "https://images.unsplash.com/photo-1504674900247-0877df9cc836",
                    Tags = "HTML,CSS,JavaScript"
                },
                new Project()
                {
                    Id = 17,
                    Name = "Expense Tracker",
                    Description = "Track your personal expenses easily.",
                    ImageSrc = "https://images.pexels.com/photos/4386375/pexels-photo-4386375.jpeg",
                    Tags = "JavaScript,HTML,CSS"
                },
                new Project()
                {
                    Id = 18,
                    Name = "Photo Gallery",
                    Description = "Responsive photo gallery with lightbox.",
                    ImageSrc = "https://images.unsplash.com/photo-1518779578993-ec3579fee39f",
                    Tags = "HTML,CSS,JavaScript"
                },
                new Project()
                {
                    Id = 19,
                    Name = "Markdown Editor",
                    Description = "Editor that converts markdown to HTML.",
                    ImageSrc = "https://images.pexels.com/photos/574071/pexels-photo-574071.jpeg",
                    Tags = "JavaScript,Markdown,HTML,CSS"
                }
            };


            modelBuilder.Entity<Project>().HasData(listaProjektow);
        }
    }
}
