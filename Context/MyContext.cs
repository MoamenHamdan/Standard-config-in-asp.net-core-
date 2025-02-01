using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace University.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> Context):base(Context) { 

        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var building = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = building.Build();
            var conString = configuration.GetConnectionString("MyDbConnection");
            optionsBuilder.UseSqlServer(conString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<University.Models.Student> Students { get; set; }
        public DbSet<University.Models.Teacher> Teachers { get; set; }



    }
}
