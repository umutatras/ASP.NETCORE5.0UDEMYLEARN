using UAUdemy.BankApp.Web.Data.Context;
using UAUdemy.BankApp.Web.Data.Interfaces;
using UAUdemy.BankApp.Web.Data.Repositories;

namespace UAUdemy.BankApp.Web.Data.UnitOfWork
{
    public class Uow:IUow
    {
        private readonly BankContext _context;

        public Uow(BankContext context)
        {
            _context = context;
        }
        public IRepository<T> GetRepository<T>() where T : class,new()
        {
            return new Repository<T>(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
