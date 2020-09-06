using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Infinity.Data
{
    public class MyIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
