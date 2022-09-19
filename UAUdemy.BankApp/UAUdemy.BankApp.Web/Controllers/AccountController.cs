using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
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
    public class AccountController : Controller
    {
        //private readonly BankContext _context;
        //private readonly IApplicatiounUserRepository _applicationUserRepository;
        //private readonly IUserMapper _userMapper;
        //private readonly IAccountRepository _accountRepository;
        //private readonly IAccountMapper _accountMapper;
        //public AccountController(BankContext context, IApplicatiounUserRepository applicationUserRepository, IUserMapper userMapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
        //{
        //    _context = context;
        //    _applicationUserRepository = applicationUserRepository;
        //    _userMapper = userMapper;
        //    _accountRepository = accountRepository;
        //    _accountMapper = accountMapper;
        //}
        //private readonly IRepository<Account> _accountRepository;
        //private readonly IRepository<ApplicationUser> _userRepository;

        //public AccountController(IRepository<Account> accountRepository, IRepository<ApplicationUser> userRepository)
        //{
        //    _accountRepository = accountRepository;
        //    _userRepository = userRepository;
        //}
        private readonly IUow _uow;

        public AccountController(IUow uow)
        {
            _uow = uow;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _uow.GetRepository<ApplicationUser>().GetById(id);

            return View(new UserListModel
            {
                Id=userInfo.Id,
                Name=userInfo.Name,
                Surname=userInfo.Surname
            });
        }
        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
            _uow.GetRepository<Account>().Create(new Account
            {
                AccountNumber= model.AccountNumber,
                Balance=model.Balance,
                ApplicationUserId=model.ApplicationUserId,  
            });
            _uow.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult GetByUserId(int userId)
        {
            var query = _uow.GetRepository<Account>().GetQueryable();
           var accountList = query.Where(x => x.ApplicationUserId == userId).ToList();
            var user= _uow.GetRepository<ApplicationUser>().GetById(userId);
            ViewBag.Fullname = user.Name + " " + user.Surname;
            var list = new List<AccountListModel>();
            foreach(var item in accountList)
            {
                list.Add(new()
                {
                    AccountNumber = item.AccountNumber,
                    ApplicationUserId = item.ApplicationUserId, 
                    Balance=item.Balance,                   
                    Id=item.id
                   
                });

            }
            return View(list);
        }
        [HttpGet]
        public IActionResult SendMoney(int accountid)
        {
            var query = _uow.GetRepository<Account>().GetQueryable();
            var accounts = query.Where(x => x.id != accountid).ToList();
            var list = new List<AccountListModel>();
            ViewBag.SenderId = accountid;
            foreach(var account in accounts)
            {
                list.Add(new()
                {
                    AccountNumber = account.AccountNumber,
                    ApplicationUserId = account.ApplicationUserId,
                    Balance = account.Balance,
                    Id = account.id
                });
            }
            var list2=new SelectList(list);

            return View(new SelectList(list,"Id","AccountNumber"));
        }
        [HttpPost]
       public IActionResult SendMoney(SendMoneyModel model)
        {
            var senderAccount= _uow.GetRepository<Account>().GetById(model.SenderId);
            senderAccount.Balance -= model.Amount;
            _uow.GetRepository<Account>().Update(senderAccount);
            var account= _uow.GetRepository<Account>().GetById(model.AccountId);
            account.Balance+=model.Amount;
            _uow.GetRepository<Account>().Update(account);
            _uow.SaveChanges();
            return RedirectToAction("Index","Home");
        }
       
    }
}
