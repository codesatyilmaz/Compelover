using System.Collections.Generic;
using Compelover.Entities.Tangible;

namespace Compelover.Business.Notional
{
    public interface IUserService
    {
        AppUser GetByUserId(string userId);
        List<AppUser> ListOfUsers();
        List<AppUser> ForComponentUsersList();
        List<AppUser> AppUsers(string userId);

        List<AppUser> SearchUser(string searchedUser);
    }
}