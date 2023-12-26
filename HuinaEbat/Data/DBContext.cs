using Microsoft.EntityFrameworkCore;
using HuinaEbat.Data;

namespace HuinaEbat.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;

        public DbSet<HuinaEbat.Data.Role> Role { get; set; } = default!;

        public DbSet<HuinaEbat.Data.Child> Child { get; set; } = default!;
    }
}
