using System.Collections.Generic;
using UAUdemy.BankApp.Web.Data.Entities;

namespace UAUdemy.BankApp.Web.Data.Interfaces
{
    public interface IApplicatiounUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}
