using System.Collections.Generic;
using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        public UserListModel MapToUserList(ApplicationUser user);
    }
}
