using UAUdemy.BankApp.Web.Data.Interfaces;

namespace UAUdemy.BankApp.Web.Data.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : class, new();
        void SaveChanges();
    }
}