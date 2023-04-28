using Microsoft.EntityFrameworkCore;

namespace Ecommerece_dotnet.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
