using Microsoft.EntityFrameworkCore;

namespace invoiceSystem.src.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {
            
        }
    }
}