using UAUdemy.BankApp.Web.Data.Context;
using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Data.Interfaces;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Data.Repositories
{
    public class AccountRepository:IAccountRepository
    {

        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }
        public void Create(Account user)
        {
            _context.Account.Add(user);
            _context.SaveChanges();
        }

      
    }

}