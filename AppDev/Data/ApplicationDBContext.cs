using Microsoft.EntityFrameworkCore;


namespace AppDev.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}