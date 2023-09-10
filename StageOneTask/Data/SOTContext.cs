using Microsoft.EntityFrameworkCore;
using StageOneTask.Entity;

namespace StageOneTask.Data
{
    public class SOTContext : DbContext
    {
        public SOTContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SOT> Task { get; set; }
    }
}
