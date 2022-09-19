using Microsoft.AspNetCore.Mvc;
using UdemyDependency.Services;

namespace UdemyDependency.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ITransientService _transientService;
        private readonly IScoppedService _scoppedService;
        private readonly ISingletonService _singletonService;

        public HomeController(IProductService productService, ITransientService transientService, IScoppedService scoppedService, ISingletonService singletonService)
        {
            _productService = productService;
            _transientService = transientService;
            _scoppedService = scoppedService;
            _singletonService = singletonService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonService.GuidId;
            ViewBag.Transient = _transientService.GuidId;
            ViewBag.Scopped= _scoppedService.GuidId;
            var values=_productService.GetTotal();
            return View();
        }
    }
    public interface IProductService
    {
        int GetTotal();
    }
    public class ProductManager:IProductService
    {
        public int GetTotal()
        {
            return 40;
        }
    }
}
