using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Services.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //here adding paraameters in brackets so as to give that paraameters in startup.cs
    }
}
