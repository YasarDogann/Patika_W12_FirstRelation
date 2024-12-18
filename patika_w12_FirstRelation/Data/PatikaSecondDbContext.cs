using Microsoft.EntityFrameworkCore;
using patika_w12_FirstRelation.Entities;

namespace patika_w12_FirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PatikaCodeFirstDb2;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        // MOdel oluşturulurken  yani vt buraya göre oluşturulur. anlat hoca anlaaat
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ilişkileri tanımladık
            modelBuilder
                .Entity<Post>()
                .HasOne(p => p.User) // her postanın bir sahibi vardır User
                .WithMany(u => u.Posts) // 1 user kardeşimizin ise birden fazla postası olabilerr
                .HasForeignKey(p => p.UserId);  // Post'daki userid ile birleştirme yaptık. Foreign key yazmıştım zaten 

            // Propertieslerden birisinin başlığının uzunluğunu 100 karakter iile burada sınırlandırmak istedim
            modelBuilder.Entity<User>()
                .Property(p => p.Name)
                .HasMaxLength(50);
        }
    }
}
