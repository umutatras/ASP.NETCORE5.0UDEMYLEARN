using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        public Account Map(AccountCreateModel model);
    }
}
