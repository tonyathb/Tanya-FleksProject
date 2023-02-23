using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FleksProject.Data
{
    public class FleksProjectDbContext : IdentityDbContext<User>
    {
        public FleksProjectDbContext(DbContextOptions<FleksProjectDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Typea> Typeas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Sport> Sports { get; set; }

    }
}