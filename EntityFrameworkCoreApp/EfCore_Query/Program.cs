using EfCore_Query.Context;
using EfCore_Query.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCore_Query
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogContext();
            context.Add(new Blog
            {
                Title = "Blog-5",
                Url = "blog.com/blog-5"
            });
            //context.Add(new Blog
            //{
            //    Title = "Blog-2",
            //    Url = "blog.com/blog-2"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog-3",
            //    Url = "blog.com/blog-3"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog-4",
            //    Url = "blog.com/blog-4"
            //});
            //context.SaveChanges();

            //Tracaking
            //var updatedBlog = context.Blogs.SingleOrDefault(x => x.Id == 1);
            //updatedBlog.Title = "Güncellendi";
            //var updatedBlogState = context.Entry(updatedBlog).State;
            //context.SaveChanges();
            //Tracaking
            //var updatedBlog = context.Blogs.AsNoTracking().SingleOrDefault(x => x.Id == 1);
            //updatedBlog.Title = "Güncellendi";
            //var updatedBlogState = context.Entry(updatedBlog).State;
            //context.SaveChanges();
            //var blogs = context.Blogs.ToList();
            //foreach (var blog in blogs)
            //{
            //    foreach (var item in blog.Comments)
            //    {
            //        Console.WriteLine($"{item.Content}");
            //    }

            // lazy loading her bir isteğe karşı 1 sorgu çalıştırır ve geri gelir performans açısından maliyetli}

            var blogs = context.Blogs.Include(x=>x.Comments.Where(x=>x.Content.Contains("yorum"))).ToList();
            foreach (var blog in blogs)
            {
                foreach (var item in blog.Comments)
                {
                    Console.WriteLine($"{item.Content}");
                }
            }
                Console.WriteLine("Hello World!");
        }
    }
}
