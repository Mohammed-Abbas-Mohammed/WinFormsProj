using Microsoft.EntityFrameworkCore;
using Models;

namespace DbCont
{
    public class ProCon: DbContext
    {
        public ProCon()
        {
        }

        public ProCon(DbContextOptions<ProCon> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderM> orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ECOMMERDESHOPSPHERE;Integrated Security=True;Encrypt=True;" +
                        "TrustServerCertificate=true");
        }
    }
}
