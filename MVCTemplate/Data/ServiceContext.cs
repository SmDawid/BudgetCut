using Microsoft.EntityFrameworkCore;

namespace MVCTemplate.Data
{
    public class ServiceContext:DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options):base(options)
        {



        } 
    }
}
