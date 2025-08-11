using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkillSnap.Shared.Models;

namespace Api.Data
{
    public class SkillSnapContext : IdentityDbContext<ApplicationUser>
    {
        public SkillSnapContext(DbContextOptions<SkillSnapContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PortfolioUser> PortfolioUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
