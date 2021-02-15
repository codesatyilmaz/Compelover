using System.Collections.Generic;
using Compelover.Entities.Tangible;

namespace Compelover.Business.Notional
{
    public interface IBlogService
    {
        List<Blog> ListOfBlog();
        Blog GetByBlogId(string blogId);
        void AddBlogPost(Blog blog);

        List<Blog> GetUserBlogCount(string userId);
        

    }
}