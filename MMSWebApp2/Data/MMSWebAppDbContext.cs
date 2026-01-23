using Microsoft.EntityFrameworkCore;
using MMSWebApp2.Models;

namespace MMSWebApp2.Data
{
    public class MMSWebAppDbContext : DbContext
    {
        public MMSWebAppDbContext(DbContextOptions<MMSWebAppDbContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; } 
    }
}
