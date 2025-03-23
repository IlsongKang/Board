using Microsoft.EntityFrameworkCore;
using BoardProject.Models;

namespace BoardProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
    }
} 