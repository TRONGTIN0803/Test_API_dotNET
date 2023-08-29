using Microsoft.EntityFrameworkCore;
using WebtestAPI.Data;

namespace WebtestAPI.Context
{
    public class TestApiContext : DbContext
    {

        public TestApiContext(DbContextOptions<TestApiContext> options)
            : base(options)
        {
        }

        public DbSet<DbProduct> products { get; set; }
        public DbSet<DbCategory> categories { get; set; }
    }
}
