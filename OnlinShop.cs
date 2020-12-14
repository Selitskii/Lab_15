using Microsoft.EntityFrameworkCore;

namespace ISP_Lab15
{
    class OnlinShop : DbContext
    {

        public OnlinShop() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OnlinShop;Trusted_Connection=True;");
        }
    }
}
