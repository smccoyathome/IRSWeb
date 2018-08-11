using IRS_Web.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace IRS_Web.API.Data
{
    public class IRSContext : DbContext
    {
        public IRSContext(DbContextOptions<IRSContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
        
    }
}