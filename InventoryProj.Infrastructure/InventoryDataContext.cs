using InvenotryProj.Core.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InventoryProj.Infrastructure
{
    public class InventoryDataContext : IdentityDbContext<ApplicationUser>
    {
        public InventoryDataContext() { }
        public InventoryDataContext(DbContextOptions<InventoryDataContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<BomDetail> BomDetails { get; set; }
        public DbSet<BomMaster> BomMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=InvDbMaster;User ID=sa;Password=68662;TrustServerCertificate=true;");
        }
    }
}
