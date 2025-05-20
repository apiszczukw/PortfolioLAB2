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
    }
}
