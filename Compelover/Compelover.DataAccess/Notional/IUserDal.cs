using System.Collections.Generic;
using Compelover.Core.DataAccess;
using Compelover.Entities.Tangible;

namespace Compelover.DataAccess.Notional
{
    public interface IUserDal : IEntityRepository<AppUser>
    {
        List<AppUser> ListOfUsers();
        List<AppUser> ForComponentUsersList();
        List<AppUser> AppUsers(string userId);
        
        List<AppUser> SearchUser(string searchedUser);
    }
}