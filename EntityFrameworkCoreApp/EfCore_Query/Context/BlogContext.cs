using EfCore_Query.Configurations;
using EfCore_Query.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Query.Context
{
    public class BlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //UseLazyLoadingProxies() lazy loading çalışması için gerekli fonksiyon
            optionsBuilder.UseSqlServer("server=DESKTOP-2GOA1TF;database=UEFCore;integrated security=true;");
            // optionsBuilder.LogTo(Console.Write);//hangi sorgunun çalıştırıldığını gösterir
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
       
            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
