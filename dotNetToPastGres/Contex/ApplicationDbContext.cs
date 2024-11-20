using dotNetToPastGres.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNetToPastGres.Contex
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }


}
