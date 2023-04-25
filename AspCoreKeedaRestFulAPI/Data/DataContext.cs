using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace AspCoreKeedaRestFulAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Employee> Employee { get; set; }
    }
}
