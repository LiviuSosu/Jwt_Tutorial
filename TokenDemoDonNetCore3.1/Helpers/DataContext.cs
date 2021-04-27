using Microsoft.EntityFrameworkCore;
using TokenDemoDonNetCore3._1.Entities;

namespace TokenDemoDonNetCore3._1.Helpers
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
