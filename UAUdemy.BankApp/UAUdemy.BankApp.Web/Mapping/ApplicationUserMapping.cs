using System.Collections.Generic;
using System.Linq;
using UAUdemy.BankApp.Web.Data.Entities;
using UAUdemy.BankApp.Web.Models;

namespace UAUdemy.BankApp.Web.Mapping
{
    public class ApplicationUserMapping:IUserMapper
    {
        public List<UserListModel> MapToListOfUserList(List<ApplicationUser> users)
        {
            return users.Select(x => new UserListModel
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }
        public UserListModel MapToUserList(ApplicationUser user)
        {
            return new UserListModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname
            };
        }
    }
}
