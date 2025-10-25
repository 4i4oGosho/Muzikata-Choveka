using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MuzikataIChoveka.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Таблици (DbSets)
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
