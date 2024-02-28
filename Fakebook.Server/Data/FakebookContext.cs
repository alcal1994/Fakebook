using Microsoft.EntityFrameworkCore;

namespace Fakebook.Server.Data
{
    public class FakebookContext : DbContext
    {
        public FakebookContext(DbContextOptions<FakebookContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            base.OnModelCreating(modelBuider);
        }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Profile> Profiles { get; set; }

    }
}
