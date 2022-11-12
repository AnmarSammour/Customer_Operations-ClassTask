using Customer_Operations.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customer_Operations.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Customers> Customers { get; set; }
    }
}
