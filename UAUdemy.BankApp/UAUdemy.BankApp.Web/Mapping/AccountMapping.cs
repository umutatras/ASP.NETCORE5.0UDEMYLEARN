using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Mapping
{
    public class AccountMapping:IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance

            };
        }
    }

}
