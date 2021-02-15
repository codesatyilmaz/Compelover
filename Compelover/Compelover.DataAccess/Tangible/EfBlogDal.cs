using System.Collections.Generic;
using System.Linq;
using Compelover.Core.DataAccess;
using Compelover.DataAccess.EntityFrameworkCore.ContextFile;
using Compelover.DataAccess.Notional;
using Compelover.Entities.Tangible;
using Microsoft.EntityFrameworkCore;

namespace Compelover.DataAccess.Tangible
{
    public class EfBlogDal : EfEntityRepository<Blog, CompeloverContext>, IBlogDal
    {
        private readonly CompeloverContext _compeloverContext;

        public EfBlogDal(CompeloverContext compeloverContext)
        {
            _compeloverContext = compeloverContext;
        }

        public List<Blog> GetUserBlogCount(string userId)
        {
            return _compeloverContext.Blogs.Where(b => b.AppUserId == userId)
                .OrderByDescending(b => b.BlogId).ToList();
        }

       
    }
}