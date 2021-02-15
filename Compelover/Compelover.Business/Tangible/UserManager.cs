using System.Collections.Generic;
using Compelover.Business.Notional;
using Compelover.DataAccess.Notional;
using Compelover.Entities.Tangible;

namespace Compelover.Business.Tangible
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public AppUser GetByUserId(string userId)
        {
            return _userDal.Get(a => a.Id == userId);
        }

        public List<AppUser> ListOfUsers()
        {
            // return _userDal.GetAll().OrderByDescending(a => a.Id).ToList();
            return _userDal.ListOfUsers();
        }

        public List<AppUser> ForComponentUsersList()
        {
            return _userDal.ForComponentUsersList();
        }

        public List<AppUser> AppUsers(string userId)
        {
            return _userDal.AppUsers(userId);
        }

        public List<AppUser> SearchUser(string searchedUser)
        {
            return _userDal.SearchUser(searchedUser);
        }
    }
}