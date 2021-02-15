using System.Collections.Generic;
using System.Linq;
using Compelover.Core.DataAccess;
using Compelover.Entities.Tangible;

namespace Compelover.DataAccess.Notional
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
        List<Blog> GetUserBlogCount(string userId);
    }
}


