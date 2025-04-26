
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using RpgMysticalforge.Models;


namespace RpgMysticalforge.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Player> Players { get; set; }
            public DbSet<Character> Characters { get; set;}
            public DbSet<CourseClass> CourseClasses { get; set; }
            public DbSet<Attributes> Attributes { get; set; }
            public DbSet<Level> Levels { get; set; } 

    }
}