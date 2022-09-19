using System.Collections.Generic;
using System.Linq;
using UAUdemy.BankApp.Web.Data.Context;
using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Data.Interfaces;

namespace UAUdemy.BankApp.Web.Data.Repositories
{
    public class ApplicationUserRepository:IApplicatiounUserRepository
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;

        }

        public List<ApplicationUser>GetAll()
        {
            return _context.ApplicationUsers.ToList();
        }
        public ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }
    }
}
