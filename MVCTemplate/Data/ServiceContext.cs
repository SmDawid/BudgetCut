using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace MVCTemplate.Data
{
    public class ServiceContext:DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options):base(options)
        {



        } 
        public DbSet<Models.Service> Services { get; set; }
    }
}
