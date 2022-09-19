using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UdemyEFCORE.Data.Contexts;
using UdemyEFCORE.Data.Entities;

namespace UdemyEFCORE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UdemyContext udemyContext = new();
            //var entity=udemyContext.Add(new Data.Entities.Product
            //{
            //    Name = "Telefon",
            //    Price = 1200
            //});
            //var updatedProdcuct = udemyContext.Products.Find(1);
            //updatedProdcuct.Price = 2500;
            //udemyContext.Products.Update(updatedProdcuct);
            //var deletedProdcuct = udemyContext.Products.Find(1);
            //|| var deletedProdcuct = udemyContext.Products.FirstOrDefault(x=>x.Id==1);
            //udemyContext.Products.Remove(deletedProdcuct);

            //udemyContext.SaveChanges();
            //udemyContext.Employees.Add(new FullTimeEmployee
            //{
            //    FirstName = "Full",
            //    LastName = "Full",
            //    DailyWage = 60
            //});
            //udemyContext.Employees.Add(new FullTimeEmployee
            //{
            //    FirstName = "Full",
            //    LastName = "Full",
            //    DailyWage = 250
            //});
            //udemyContext.Employees.Add(new PartTimeEmployee
            //{
            //    FirstName = "part",
            //    LastName = "part",
            //    HourlyWage = 15
            //});
            //udemyContext.Employees.Add(new PartTimeEmployee
            //{
            //    FirstName = "part",
            //    LastName = "part",
            //    HourlyWage = 12
            //});
            //udemyContext.SaveChanges();
           //var part=udemyContext.Employees.Where(x=>x is PartTimeEmployee).ToList();//part time olanları listeleme
        
            return View();
        }
    }
}
