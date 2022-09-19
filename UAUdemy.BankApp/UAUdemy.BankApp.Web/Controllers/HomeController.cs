using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UAUdemy.BankApp.Web.Data.Context;
using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Data.Interfaces;
using UAUdemy.BankApp.Web.Data.Repositories;
using UAUdemy.BankApp.Web.Data.UnitOfWork;
using UAUdemy.BankApp.Web.Mapping;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly BankContext _context;
        //private readonly IApplicatiounUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        private readonly IUow _uow;
        public HomeController(IUserMapper userMapper, IUow uow)
        {
            _userMapper = userMapper;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }
    }
}
