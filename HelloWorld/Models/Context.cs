using Microsoft.EntityFrameworkCore;
namespace HelloWorld.Models
{
    public class HWContext : DbContext
    {
        public HWContext()
        { }

        public HWContext(DbContextOptions<HWContext> options)
            : base(options)
        { }

        public DbSet<World> Worlds { get; set; }
    }
}
