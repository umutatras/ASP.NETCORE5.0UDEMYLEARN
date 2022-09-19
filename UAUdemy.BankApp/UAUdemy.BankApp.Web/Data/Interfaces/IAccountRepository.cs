using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        
        public void Create(Account user);
    }
}
