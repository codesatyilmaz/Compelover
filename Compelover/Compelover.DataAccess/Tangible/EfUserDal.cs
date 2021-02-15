using System.Collections.Generic;
using System.Linq;
using Compelover.Core.DataAccess;
using Compelover.DataAccess.EntityFrameworkCore.ContextFile;
using Compelover.DataAccess.Notional;
using Compelover.Entities.Tangible;
using Microsoft.EntityFrameworkCore;

namespace Compelover.DataAccess.Tangible
{
    public class EfUserDal : EfEntityRepository<AppUser, CompeloverContext>, IUserDal
    {
        private readonly CompeloverContext _compeloverContext;

        public EfUserDal(CompeloverContext compeloverContext)
        {
            _compeloverContext = compeloverContext;
        }

        public List<AppUser> ListOfUsers()
        {
            var appUsers = _compeloverContext.AppUsers.ToList().OrderByDescending(a => a.Id).ToList();
            return appUsers;
        }

        public List<AppUser> ForComponentUsersList()
        {
            return _compeloverContext.AppUsers.Take(20).ToList();
        }

        public List<AppUser> AppUsers(string userId)
        {
            return _compeloverContext.AppUsers.Where(a => a.Id == userId)
                .OrderByDescending(a => a.Id).ToList();
        }

        public List<AppUser> SearchUser(string searchedUser)
        {
            return _compeloverContext.AppUsers.Where(a =>
                a.Name.Contains(searchedUser) || a.UserName.Contains(searchedUser) ||
                a.SurName.Contains(searchedUser) || a.Email.Contains(searchedUser)).ToList();
        }
    }
}