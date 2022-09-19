using Microsoft.EntityFrameworkCore;
using UdemyEFCORE.Data.Entities;

namespace UdemyEFCORE.Data.Contexts
{
    public class UdemyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2GOA1TF;database=UdemyEFCORE;integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent api ile table ismini değiştirme ve şema adlandırma
            //modelBuilder.Entity<Category>().ToTable(name: "Category", schema: "dbo");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("Adlandırma");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            //modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
            //modelBuilder.Entity<Customer>().HasKey(x => x.Number);//birincil anahtar yapma
            //modelBuilder.Entity<Customer>().HasKey(x => new{ x.Number,x.Surname});//aynı tabloda birden fazla birincil anahtar yapma
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("'Ürün bilgisi girilmemiş'");//ürün bilgisi girilmediyse default olarak bu değer girilsin
            //modelBuilder.Entity<Product>().Property(x => x.createDate).HasDefaultValueSql("getdate()");
            //modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);//Örnek olarak telefon isminde bir değer var daha girilmek istenirse buna izin vermez
            //modelBuilder.Entity<Product>().HasMany(x=>x.SaleHistories).WithOne(x=>x.Product).HasForeignKey(x=>x.ProductId);//fluent api ile ilişki tanımlama bire çok
            //modelBuilder.Entity<SaleHistory>().HasOne(x => x.Product).WithMany(x => x.SaleHistories).HasForeignKey(x => x.ProductId); ;//fluent api ile ilişki tanımlama bire çok
            //modelBuilder.Entity<Product>().HasOne(x=>x.ProductDetail).WithOne(x=>x.Product).HasForeignKey<ProductDetail>(x=>x.ProductId);//birebir ilişki uygulama
            //modelBuilder.Entity<Product>().HasMany(x => x.ProductCategories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);//çoka çok ilişki
            //modelBuilder.Entity<Category>().HasMany(x => x.ProductCategories).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);//çoka çok ilişki
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId });
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");



        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SaleHistory> SaleHistories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons { get; set; }
      
      
    }
}
