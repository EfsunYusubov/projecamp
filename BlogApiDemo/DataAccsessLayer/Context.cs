using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccsessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= .\\SQLEXPRESS; database= CoreBlogApiDb; integrated security=true;");
        }
        public DbSet <Employee> Employees { get; set; }

    }
}
